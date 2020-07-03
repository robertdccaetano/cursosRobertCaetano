CREATE DATABASE curso_sql;

USE curso_sql;

CREATE TABLE tb_funcionarios
(
	id int unsigned not null auto_increment,
    nome varchar(45) not null,
    salario double not null default '0',
    departamento varchar(45) not null,
    PRIMARY KEY (id)
);

CREATE TABLE tb_veiculos
(
	id int unsigned not null auto_increment,
    id_funcionario int unsigned default null, 	
    veiculo varchar(45) not null default '',
	placa varchar(10) not null default '',
    PRIMARY KEY (id),
    CONSTRAINT fk_veiculos_funcionarios FOREIGN KEY (id_funcionario) REFERENCES tb_funcionarios (id)
);

CREATE TABLE tb_salario
(
	faixa varchar(45) not null,
    inicio double not null,
    fim double not null,
    PRIMARY KEY (faixa)
);

ALTER TABLE tb_funcionarios CHANGE COLUMN nome nome_func varchar(45) not null;
ALTER TABLE tb_funcionarios CHANGE COLUMN nome_func nome varchar(45) not null;

DROP TABLE tb_salario ;

CREATE INDEX indc_departamentos ON tb_funcionarios (departamento);
CREATE INDEX indc_nome ON tb_funcionarios (nome(6));