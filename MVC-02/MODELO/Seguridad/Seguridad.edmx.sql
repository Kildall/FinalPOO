
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/14/2022 19:49:23
-- Generated from EDMX file: C:\Users\Kildall\Desktop\Tets\FinalPOO\MVC-02\MODELO\Seguridad\Seguridad.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Seguridad];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FormularioSet'
CREATE TABLE [dbo].[FormularioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermisoSet'
CREATE TABLE [dbo].[PermisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [nombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PerfilSet'
CREATE TABLE [dbo].[PerfilSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [dni] nvarchar(max)  NOT NULL,
    [apellido] nvarchar(max)  NOT NULL,
    [mail] nvarchar(max)  NOT NULL,
    [contraseña] nvarchar(max)  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilFormulario'
CREATE TABLE [dbo].[PerfilFormulario] (
    [Perfiles_Id] int  NOT NULL,
    [Formularios_Id] int  NOT NULL
);
GO

-- Creating table 'FormularioPermiso'
CREATE TABLE [dbo].[FormularioPermiso] (
    [Formularios_Id] int  NOT NULL,
    [Permisos_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FormularioSet'
ALTER TABLE [dbo].[FormularioSet]
ADD CONSTRAINT [PK_FormularioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [PK_PermisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PerfilSet'
ALTER TABLE [dbo].[PerfilSet]
ADD CONSTRAINT [PK_PerfilSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Perfiles_Id], [Formularios_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [PK_PerfilFormulario]
    PRIMARY KEY CLUSTERED ([Perfiles_Id], [Formularios_Id] ASC);
GO

-- Creating primary key on [Formularios_Id], [Permisos_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [PK_FormularioPermiso]
    PRIMARY KEY CLUSTERED ([Formularios_Id], [Permisos_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Perfil_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioPerfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPerfil'
CREATE INDEX [IX_FK_UsuarioPerfil]
ON [dbo].[UsuarioSet]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Perfiles_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Perfil]
    FOREIGN KEY ([Perfiles_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formularios_Id] in table 'PerfilFormulario'
ALTER TABLE [dbo].[PerfilFormulario]
ADD CONSTRAINT [FK_PerfilFormulario_Formulario]
    FOREIGN KEY ([Formularios_Id])
    REFERENCES [dbo].[FormularioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilFormulario_Formulario'
CREATE INDEX [IX_FK_PerfilFormulario_Formulario]
ON [dbo].[PerfilFormulario]
    ([Formularios_Id]);
GO

-- Creating foreign key on [Formularios_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Formulario]
    FOREIGN KEY ([Formularios_Id])
    REFERENCES [dbo].[FormularioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permisos_Id] in table 'FormularioPermiso'
ALTER TABLE [dbo].[FormularioPermiso]
ADD CONSTRAINT [FK_FormularioPermiso_Permiso]
    FOREIGN KEY ([Permisos_Id])
    REFERENCES [dbo].[PermisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioPermiso_Permiso'
CREATE INDEX [IX_FK_FormularioPermiso_Permiso]
ON [dbo].[FormularioPermiso]
    ([Permisos_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------