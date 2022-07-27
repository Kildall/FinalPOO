
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/27/2022 15:16:53
-- Generated from EDMX file: C:\Users\Pedro\Desktop\Programacion\POO\FinalPOO\MVC-02\MODELO\Seguridad\Seguridad.edmx
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

IF OBJECT_ID(N'[dbo].[FK_FormularioPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermisoSet] DROP CONSTRAINT [FK_FormularioPermiso];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilFormulario_Formulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilFormulario] DROP CONSTRAINT [FK_PerfilFormulario_Formulario];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilFormulario_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilFormulario] DROP CONSTRAINT [FK_PerfilFormulario_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilPermiso] DROP CONSTRAINT [FK_PerfilPermiso_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso_Permiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilPermiso] DROP CONSTRAINT [FK_PerfilPermiso_Permiso];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioPerfil];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FormularioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormularioSet];
GO
IF OBJECT_ID(N'[dbo].[PerfilFormulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilFormulario];
GO
IF OBJECT_ID(N'[dbo].[PerfilPermiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilPermiso];
GO
IF OBJECT_ID(N'[dbo].[PerfilSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilSet];
GO
IF OBJECT_ID(N'[dbo].[PermisoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermisoSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO

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
    [nombreSistema] nvarchar(max)  NOT NULL,
    [Formulario_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilSet'
CREATE TABLE [dbo].[PerfilSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(50)  NOT NULL,
    [empresa_id] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(50)  NOT NULL,
    [dni] bigint  NOT NULL,
    [apellido] nvarchar(50)  NOT NULL,
    [mail] nvarchar(90)  NOT NULL,
    [contraseña] nvarchar(max)  NOT NULL,
    [empresa_id] int  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilFormulario'
CREATE TABLE [dbo].[PerfilFormulario] (
    [Perfiles_Id] int  NOT NULL,
    [Formularios_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilPermiso'
CREATE TABLE [dbo].[PerfilPermiso] (
    [Perfiles_Id] int  NOT NULL,
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

-- Creating primary key on [Perfiles_Id], [Permisos_Id] in table 'PerfilPermiso'
ALTER TABLE [dbo].[PerfilPermiso]
ADD CONSTRAINT [PK_PerfilPermiso]
    PRIMARY KEY CLUSTERED ([Perfiles_Id], [Permisos_Id] ASC);
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

-- Creating foreign key on [Perfiles_Id] in table 'PerfilPermiso'
ALTER TABLE [dbo].[PerfilPermiso]
ADD CONSTRAINT [FK_PerfilPermiso_Perfil]
    FOREIGN KEY ([Perfiles_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permisos_Id] in table 'PerfilPermiso'
ALTER TABLE [dbo].[PerfilPermiso]
ADD CONSTRAINT [FK_PerfilPermiso_Permiso]
    FOREIGN KEY ([Permisos_Id])
    REFERENCES [dbo].[PermisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilPermiso_Permiso'
CREATE INDEX [IX_FK_PerfilPermiso_Permiso]
ON [dbo].[PerfilPermiso]
    ([Permisos_Id]);
GO

-- Creating foreign key on [Formulario_Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [FK_FormularioPermiso]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[FormularioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioPermiso'
CREATE INDEX [IX_FK_FormularioPermiso]
ON [dbo].[PermisoSet]
    ([Formulario_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------