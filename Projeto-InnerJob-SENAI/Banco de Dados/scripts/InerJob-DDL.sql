CREATE DATABASE InerJob
GO

USE InerJob
GO

-- TIPO USUARIO
CREATE TABLE tipoUsuario(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	tituloTipoUsuario VARCHAR(30) UNIQUE NOT NULL
);
GO

-- USUARIO
CREATE TABLE usuario (
	idUsuario INT PRIMARY KEY IDENTITY,
	idTipoUsuario INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario),
	nomeUsuario VARCHAR(50) NOT NULL,
	email VARCHAR(200) UNIQUE NOT NULL,
	senha VARCHAR(10) NOT NULL
);
GO

-- NOTIFICAÇÃO
CREATE TABLE notificação (
	idNotificacao INT PRIMARY KEY IDENTITY,
	idTipoUsuario INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario),

);
GO

