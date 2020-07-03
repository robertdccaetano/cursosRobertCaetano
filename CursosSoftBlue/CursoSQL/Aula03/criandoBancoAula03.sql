CREATE DATABASE exercicios_curso_sql;

USE exercicios_curso_sql;

CREATE TABLE tb_alunos(
	id int unsigned not null auto_increment,
    nome varchar(45) not null,
    telefone varchar(12) not null,
    email varchar(45) not null,
    PRIMARY KEY (id)
);

CREATE TABLE tb_instrutor(
	id int unsigned not null auto_increment,
    instrutor varchar(45) not null,
    telefone varchar(12) not null,
    PRIMARY KEY (id)
);

CREATE TABLE tb_tipo_cursos(
	codigo int unsigned not null auto_increment,
    tipo varchar(45) not null,
    PRIMARY KEY (codigo)
);

CREATE TABLE tb_cursos(
	id int unsigned not null auto_increment,
    nome varchar(45) not null,
    id_curso int unsigned not null,
    id_instrutor int unsigned not null,
    preco float unsigned not null,
    PRIMARY KEY (id),
    CONSTRAINT fk_cursos_tipo_cursos FOREIGN KEY (id_curso) REFERENCES tb_tipo_cursos (codigo),
    CONSTRAINT fk_cursos_instrutor FOREIGN KEY (id_instrutor) REFERENCES tb_instrutor (id)
);

ALTER TABLE tb_cursos CHANGE COLUMN id_curso id_curso int unsigned not null;
ALTER TABLE tb_cursos CHANGE COLUMN id_instrutor id_instrutor int unsigned not null;

 CREATE TABLE tb_pedido(
	numero_pedido int unsigned not null auto_increment,
    id_aluno int unsigned not null,
    data_pedido date not null,
    hora_pedido time not null,
    PRIMARY KEY (numero_pedido),
    CONSTRAINT fk_pedido_aluno FOREIGN KEY (id_aluno) REFERENCES tb_alunos (id)
 );
 
 ALTER TABLE tb_pedido CHANGE COLUMN id_aluno id_aluno int unsigned not null;
 
 CREATE TABLE tb_detalhe_pedido(
	id_numero_pedido int unsigned not null ,
    id_curso int unsigned not null,
    valor_curso float unsigned not null,
    PRIMARY KEY (id_numero_pedido, id_curso),
    CONSTRAINT fk_tb_detalhes_pedido_tb_pedido FOREIGN KEY (id_numero_pedido) REFERENCES tb_pedido (numero_pedido),
    CONSTRAINT fk_tb_pedido_tb_curso FOREIGN KEY (id_curso) REFERENCES tb_cursos (id)
 );

/* Mudando valor da tb_detalhe_pedido  coluna valor_curso */
ALTER TABLE tb_detalhe_pedido CHANGE COLUMN valor_curso valor_curso double unsigned not null;
/*Adicionando coluna data_nascimento na tb_alunos */
ALTER TABLE tb_alunos ADD COLUMN data_nascimento varchar(10) not null ;
/*Mudando tipo da coluna data_nascimento */
ALTER TABLE tb_alunos CHANGE COLUMN data_nascimento data_nascimento date not null;
/* Criando indice de nome de alunos na tb_alunos com o campo (nome)*/
CREATE INDEX ind_aluno ON tb_alunos (nome);
/*Adicionando coluna e-mail na tb_instrutor*/
ALTER TABLE tb_instrutor ADD COLUMN email varchar(100) not null;
/*Criando inidice de instrutores na tb_cursos através da foreign key id_instrutor */
CREATE INDEX indx_instrutor ON tb_cursos (id_instrutor);
/*Removendo coluna email da tb_instrutor*/
ALTER TABLE tb_instrutor DROP COLUMN email;
/*Criando INDEX de outra maneira e logo em seguida dando DROP nele*/
ALTER TABLE tb_cursos ADD INDEX INDEX_INSTRUTOR(id_instrutor);
ALTER TABLE tb_cursos DROP INDEX INDEX_INSTRUTOR;
