CREATE DATABASE softblue_curso_sql;
USE softblue_curso_sql;

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
    CONSTRAINT fk_tb_cursos_tb_tipo_cursos FOREIGN KEY (id_curso) REFERENCES tb_tipo_cursos (codigo),
    CONSTRAINT fk_tb_cursos_tb_instrutor FOREIGN KEY (id_instrutor) REFERENCES tb_instrutor (id)
);

CREATE TABLE tb_pedido(
	numero_pedido int unsigned not null auto_increment,
    id_aluno int unsigned not null,
    data_pedido date not null,
    hora_pedido time not null,
    PRIMARY KEY (numero_pedido),
    CONSTRAINT fk_tb_pedido_tb_alunos FOREIGN KEY (id_aluno) REFERENCES tb_alunos (id)
);

CREATE TABLE tb_detalhe_pedido (
	id_numero_pedido int unsigned not null,
    id_curso int unsigned not null,
    valor_curso float unsigned not null,
    PRIMARY KEY (id_numero_pedido, id_curso),
    CONSTRAINT fk_tb_detalhe_pedido_tb_pedido FOREIGN KEY (id_numero_pedido) REFERENCES tb_pedido (numero_pedido),
	CONSTRAINT fk_tb_detalhe_pedido_tb_cursos FOREIGN KEY (id_curso) REFERENCES tb_cursos (id)
);

/*Exercício 2 */
/*Adicionando coluna data_nascimento na tb_alunos */
ALTER TABLE tb_alunos ADD COLUMN data_nascimento varchar(10) not null;
/*Altera coluna data_nascimento para nascimento e o seu tipo para DATE */
ALTER TABLE tb_alunos CHANGE COLUMN data_nascimento nascimento date not null;
/*Criando indíce na tabela aluno referenciando o campo nome*/
CREATE INDEX ind_aluno ON tb_aluno (nome);
/*Adicionando campo e-mail na tb_instrutor */
ALTER TABLE tb_instrutor ADD COLUMN email varchar(100) not null;
/* Criando indice na tabela curo para o campo instrutor */
CREATE INDEX ind_instrutor_curso ON tb_cursos (id_instrutor);
/*Removendo campo e-mail da tb_instrutor; */
ALTER TABLE tb_instrutor DROP COLUMN email;





    