CREATE DATABASE Jose_Sanchez_Parcial3;
GO
--
USE Jose_Sanchez_Parcial3;
GO

CREATE TABLE Autores (
    AutorId INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL,
    Apellido VARCHAR(150) NOT NULL,
    Nacionalidad VARCHAR(100) NULL
);
GO

CREATE TABLE Revistas (
    RevistaId INT IDENTITY(1,1) PRIMARY KEY,
    NombreRevista VARCHAR(200) NOT NULL,
    ISSN VARCHAR(50) NULL
);
GO

CREATE TABLE Articulos (
    ArticuloId INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(250) NOT NULL,
    Resumen TEXT NULL,
    FechaPublicacion DATE NULL,
    RevistaId INT NOT NULL,

    CONSTRAINT FK_Articulos_Revistas
        FOREIGN KEY (RevistaId) REFERENCES Revistas(RevistaId)
);
GO

CREATE TABLE ArticulosAutores (
    ArticuloId INT NOT NULL,
    AutorId INT NOT NULL,

    CONSTRAINT PK_ArticulosAutores PRIMARY KEY (ArticuloId, AutorId),

    CONSTRAINT FK_AA_Articulos FOREIGN KEY (ArticuloId)
        REFERENCES Articulos(ArticuloId),

    CONSTRAINT FK_AA_Autores FOREIGN KEY (AutorId)
        REFERENCES Autores(AutorId)
);
GO
