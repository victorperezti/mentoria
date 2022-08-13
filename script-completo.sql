CREATE DATABASE [Mentoria]
GO

USE [Mentoria]
GO

CREATE TABLE [Aluno] 
(
    [Id] uniqueidentifier NOT NULL,
    [Nome] NVARCHAR(120) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL,
    [CPF] VARCHAR(11) NOT NULL,    
    [DataCriacao] DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT [PK_Aluno] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Autor]
(
    [Id] uniqueidentifier NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL, 
    [Bio] NVARCHAR(2000) NOT NULL,    
    [Email] NVARCHAR(160) NOT NULL,
    CONSTRAINT [PK_Autor] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Categoria]
(
    [Id] uniqueidentifier NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Descricao] TEXT NOT NULL
    CONSTRAINT [PK_Categoria] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Curso]
(
    [Id] uniqueidentifier NOT NULL,
    [Titulo] NVARCHAR(160) NOT NULL,
    [Descricao] NVARCHAR(2000) NOT NULL,
    [DuracaoEmMinutos] INT NOT NULL,
    [DataCriacao] DATETIME NOT NULL,
    [DataUltimaAtualizacao] DATETIME NOT NULL,
    [AutorId] uniqueidentifier NOT NULL,
    [CategoriaId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Curso] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Curso_Autor_AutorId] FOREIGN KEY ([AutorId]) REFERENCES [Autor] ([Id]),
    CONSTRAINT [FK_Curso_Categoria_CategorioaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categoria] ([Id])
);
GO

CREATE TABLE [AlunoCurso]
(
    [CoursoId] uniqueidentifier NOT NULL,
    [AlunoId] uniqueidentifier NOT NULL,
    [Progresso] TINYINT NOT NULL,
    [DataInicio] DATETIME NOT NULL,
    [UltimaDataAtualizacao] DATETIME NULL DEFAULT(GETDATE()),
    CONSTRAINT [PK_EstudanteCurso] PRIMARY KEY ([CoursoId], [AlunoId]),
    CONSTRAINT [FK_AlunoCurso_Curso_CursoId] FOREIGN KEY ([CoursoId]) REFERENCES [Curso] ([Id]),
    CONSTRAINT [FK_AlunoCurso_Aluno_AlunoId] FOREIGN KEY ([AlunoId]) REFERENCES [Aluno] ([Id])
);
GO