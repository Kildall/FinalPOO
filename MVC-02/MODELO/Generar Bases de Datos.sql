
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/12/2022 23:51:51
-- Generated from EDMX file: D:\Visual Studio\Proyectos\II AÑO\MVC\MVC-02\MVC-02\MODELO\EmpresaDB.edmx
-- --------------------------------------------------
   

SET QUOTED_IDENTIFIER OFF;
IF DB_ID('EmpresaDB') IS NULL EXECUTE(N'CREATE DATABASE EmpresaDB');
GO
USE [EmpresaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoriaEmpresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Categorias] DROP CONSTRAINT [FK_CategoriaEmpresa];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_EmpleadoCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoEmpleado_Empleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpleadoEmpleado] DROP CONSTRAINT [FK_EmpleadoEmpleado_Empleado];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoEmpleado_Empleado1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpleadoEmpleado] DROP CONSTRAINT [FK_EmpleadoEmpleado_Empleado1];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpresaCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_EmpresaCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpresaEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_EmpresaEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosEmpresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [FK_ProductosEmpresa];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosVentas_Productos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductosVentas] DROP CONSTRAINT [FK_ProductosVentas_Productos];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosVentas_Ventas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductosVentas] DROP CONSTRAINT [FK_ProductosVentas_Ventas];
GO
IF OBJECT_ID(N'[dbo].[FK_VentasCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ventas] DROP CONSTRAINT [FK_VentasCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_VentasEmpresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ventas] DROP CONSTRAINT [FK_VentasEmpresa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[EmpleadoEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpleadoEmpleado];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresa];
GO
IF OBJECT_ID(N'[dbo].[Productos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Productos];
GO
IF OBJECT_ID(N'[dbo].[ProductosVentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductosVentas];
GO
IF OBJECT_ID(N'[dbo].[Ventas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ventas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [edad] nvarchar(max)  NOT NULL,
    [telefono] nvarchar(max)  NOT NULL,
    [Empresa_Id] int  NOT NULL
);
GO

-- Creating table 'Empresa'
CREATE TABLE [dbo].[Empresa] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [edad] nvarchar(max)  NOT NULL,
    [salario] nvarchar(max)  NOT NULL,
    [Empresa_Id] int  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [Empresa_Id] int  NOT NULL
);
GO

-- Creating table 'Productos'
CREATE TABLE [dbo].[Productos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [cantidad] nvarchar(max)  NOT NULL,
    [precio] nvarchar(max)  NOT NULL,
    [Empresa_Id] int  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [total] nvarchar(max)  NOT NULL,
    [Empresa_Id] int  NOT NULL,
    [Empleado_Id] int  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'EmpleadoEmpleado'
CREATE TABLE [dbo].[EmpleadoEmpleado] (
    [Subordinados_Id] int  NOT NULL,
    [Superior_Id] int  NOT NULL
);
GO

-- Creating table 'ProductosVentas'
CREATE TABLE [dbo].[ProductosVentas] (
    [Productos_Id] int  NOT NULL,
    [Ventas_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empresa'
ALTER TABLE [dbo].[Empresa]
ADD CONSTRAINT [PK_Empresa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [PK_Empleados]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [PK_Productos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Subordinados_Id], [Superior_Id] in table 'EmpleadoEmpleado'
ALTER TABLE [dbo].[EmpleadoEmpleado]
ADD CONSTRAINT [PK_EmpleadoEmpleado]
    PRIMARY KEY CLUSTERED ([Subordinados_Id], [Superior_Id] ASC);
GO

-- Creating primary key on [Productos_Id], [Ventas_Id] in table 'ProductosVentas'
ALTER TABLE [dbo].[ProductosVentas]
ADD CONSTRAINT [PK_ProductosVentas]
    PRIMARY KEY CLUSTERED ([Productos_Id], [Ventas_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Empresa_Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_EmpresaCliente]
    FOREIGN KEY ([Empresa_Id])
    REFERENCES [dbo].[Empresa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaCliente'
CREATE INDEX [IX_FK_EmpresaCliente]
ON [dbo].[Clientes]
    ([Empresa_Id]);
GO

-- Creating foreign key on [Empresa_Id] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_EmpresaEmpleado]
    FOREIGN KEY ([Empresa_Id])
    REFERENCES [dbo].[Empresa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaEmpleado'
CREATE INDEX [IX_FK_EmpresaEmpleado]
ON [dbo].[Empleados]
    ([Empresa_Id]);
GO

-- Creating foreign key on [Categoria_Id] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_EmpleadoCategoria]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoCategoria'
CREATE INDEX [IX_FK_EmpleadoCategoria]
ON [dbo].[Empleados]
    ([Categoria_Id]);
GO

-- Creating foreign key on [Subordinados_Id] in table 'EmpleadoEmpleado'
ALTER TABLE [dbo].[EmpleadoEmpleado]
ADD CONSTRAINT [FK_EmpleadoEmpleado_Empleado]
    FOREIGN KEY ([Subordinados_Id])
    REFERENCES [dbo].[Empleados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Superior_Id] in table 'EmpleadoEmpleado'
ALTER TABLE [dbo].[EmpleadoEmpleado]
ADD CONSTRAINT [FK_EmpleadoEmpleado_Empleado1]
    FOREIGN KEY ([Superior_Id])
    REFERENCES [dbo].[Empleados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoEmpleado_Empleado1'
CREATE INDEX [IX_FK_EmpleadoEmpleado_Empleado1]
ON [dbo].[EmpleadoEmpleado]
    ([Superior_Id]);
GO

-- Creating foreign key on [Productos_Id] in table 'ProductosVentas'
ALTER TABLE [dbo].[ProductosVentas]
ADD CONSTRAINT [FK_ProductosVentas_Productos]
    FOREIGN KEY ([Productos_Id])
    REFERENCES [dbo].[Productos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Ventas_Id] in table 'ProductosVentas'
ALTER TABLE [dbo].[ProductosVentas]
ADD CONSTRAINT [FK_ProductosVentas_Ventas]
    FOREIGN KEY ([Ventas_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosVentas_Ventas'
CREATE INDEX [IX_FK_ProductosVentas_Ventas]
ON [dbo].[ProductosVentas]
    ([Ventas_Id]);
GO

-- Creating foreign key on [Empresa_Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [FK_CategoriaEmpresa]
    FOREIGN KEY ([Empresa_Id])
    REFERENCES [dbo].[Empresa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaEmpresa'
CREATE INDEX [IX_FK_CategoriaEmpresa]
ON [dbo].[Categorias]
    ([Empresa_Id]);
GO

-- Creating foreign key on [Empresa_Id] in table 'Productos'
ALTER TABLE [dbo].[Productos]
ADD CONSTRAINT [FK_ProductosEmpresa]
    FOREIGN KEY ([Empresa_Id])
    REFERENCES [dbo].[Empresa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosEmpresa'
CREATE INDEX [IX_FK_ProductosEmpresa]
ON [dbo].[Productos]
    ([Empresa_Id]);
GO

-- Creating foreign key on [Empresa_Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK_VentasEmpresa]
    FOREIGN KEY ([Empresa_Id])
    REFERENCES [dbo].[Empresa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasEmpresa'
CREATE INDEX [IX_FK_VentasEmpresa]
ON [dbo].[Ventas]
    ([Empresa_Id]);
GO

-- Creating foreign key on [Empleado_Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK_EmpleadoVentas]
    FOREIGN KEY ([Empleado_Id])
    REFERENCES [dbo].[Empleados]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoVentas'
CREATE INDEX [IX_FK_EmpleadoVentas]
ON [dbo].[Ventas]
    ([Empleado_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK_ClienteVentas]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVentas'
CREATE INDEX [IX_FK_ClienteVentas]
ON [dbo].[Ventas]
    ([Cliente_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

INSERT INTO Empresa (nombre) VALUES ('Franco');
INSERT INTO Empresa (nombre) VALUES ('Paula');
INSERT INTO Empresa (nombre) VALUES ('Pedro');

INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier I', 1);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier II', 1);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier III', 1);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier IV', 1);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier V', 1);

INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier I', 2);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier II', 2);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier III', 2);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier IV', 2);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier V', 2);

INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier I', 3);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier II', 3);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier III', 3);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier IV', 3);
INSERT INTO Categorias (nombre, Empresa_Id) VALUES ('Tier V', 3);



-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------


-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/26/2022 21:30:30
-- Generated from EDMX file: C:\Users\Pedro\Desktop\Programacion\POO\FinalPOO\MVC-02\MODELO\Seguridad\Seguridad.edmx
-- --------------------------------------------------

IF DB_ID('Seguridad') IS NULL EXECUTE(N'CREATE DATABASE Seguridad');
GO
USE [Seguridad];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuarioPerfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuarioSet] DROP CONSTRAINT [FK_UsuarioPerfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilFormulario_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilFormulario] DROP CONSTRAINT [FK_PerfilFormulario_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilFormulario_Formulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilFormulario] DROP CONSTRAINT [FK_PerfilFormulario_Formulario];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso_Perfil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilPermiso] DROP CONSTRAINT [FK_PerfilPermiso_Perfil];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso_Permiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PerfilPermiso] DROP CONSTRAINT [FK_PerfilPermiso_Permiso];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FormularioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormularioSet];
GO
IF OBJECT_ID(N'[dbo].[PermisoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermisoSet];
GO
IF OBJECT_ID(N'[dbo].[PerfilSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[PerfilFormulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilFormulario];
GO
IF OBJECT_ID(N'[dbo].[PerfilPermiso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PerfilPermiso];
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
    [nombre] nvarchar(max)  NOT NULL,
    [empresa_id] int  NOT NULL
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
--Perfiles

INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Dueño', 1);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Gerente', 1);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Empleado', 1);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Cliente', 1);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Nadie', 1);

INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Dueño', 2);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Gerente', 2);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Empleado', 2);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Cliente', 2);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Nadie', 2);

INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Dueño', 3);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Gerente', 3);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Empleado', 3);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Cliente', 3);
INSERT INTO PerfilSet (nombre, empresa_id) VALUES ('Nadie', 3);

--Formularios

INSERT INTO FormularioSet (nombre) VALUES ('Jerarquia');
INSERT INTO FormularioSet (nombre) VALUES ('Clientes');
INSERT INTO FormularioSet (nombre) VALUES ('Empleados');

--Permisos

    --Clientes
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Agregar Cliente', 'btnAgregarCliente', 2);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Eliminar Cliente', 'btnEliminarCliente', 2);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Modificar Cliente', 'btnModificarCliente', 2);

    --Empleados
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Agregar Empleado', 'btnAgregarEmpleado', 3);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Eliminar Empleado', 'btnEliminarEmpleado', 3);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Modificar Empleado', 'btnModificarEmpleado', 3);

    --Jerarquia
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Agregar Superior', 'btnAgregarSuperior', 1);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Agregar Subordinado', 'btnAgregarSubordinado', 1);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Eliminar Superior', 'btnEliminarSuperior', 1);
    INSERT INTO PermisoSet (nombre, nombreSistema, Formulario_Id) VALUES ('Eliminar Subordinado', 'btnEliminarSubordinado', 1);

--Formularios que puede acceder cada perfil

    --Dueño
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (1, 1)
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (1, 2)
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (1, 3)

    --Gerente
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (2, 2)
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (2, 3)

    --Empleado
    INSERT INTO PerfilFormulario (Perfiles_Id, Formularios_Id) VALUES (3, 2)

----Permisos que tiene cada formulario

--    --Jerarquia
