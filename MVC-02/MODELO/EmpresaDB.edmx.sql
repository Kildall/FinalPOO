
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/12/2022 13:32:03
-- Generated from EDMX file: C:\Users\Pedro\Desktop\Programacion\POO\FinalPOO\MVC-02\MODELO\EmpresaDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
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