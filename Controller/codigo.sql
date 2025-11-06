CREATE DATABASE APPCURSOS
USE APPCURSOS

CREATE TABLE Curso(
    pk_id_curso INT PRIMARY KEY IDENTITY,
    nome_curso VARCHAR(50) NOT NULL UNIQUE,
    link_curso VARCHAR(255) NOT NULL UNIQUE,
    status_curso VARCHAR(30) NOT NULL
);


CREATE PROCEDURE cadastrar_curso(@nome VARCHAR(50), @link VARCHAR(255), @status VARCHAR(30))
AS
BEGIN
    INSERT INTO Curso(nome_curso, link_curso, status_curso)
    VALUES(@nome, @link, @status);
END;


CREATE PROCEDURE deletar_curso(@pk INT)
AS
BEGIN
    DELETE FROM Curso
    WHERE pk_id_curso = @pk
END;
