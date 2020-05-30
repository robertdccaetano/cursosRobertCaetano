USE softblue_cursosql_aulas;
USE softblue_curso_exercicios;

SELECT * FROM tb_funcionarios;
SELECT * FROM tb_veiculos;

/* Inner Join */
SELECT * FROM tb_funcionarios INNER JOIN tb_veiculos ON id_funcionario = tb_funcionarios.id;
SELECT * FROM tb_funcionarios f INNER JOIN tb_veiculos v ON v.id_funcionario = f.id; 

/*Left Join */
SELECT * FROM tb_funcionarios f LEFT JOIN tb_veiculos v ON v.id_funcionario = f.id;

/*Right Join */
SELECT * FROM tb_funcionarios f RIGHT JOIN tb_veiculos v ON v.id_funcionario = f.id;

/*FULL JOIN*/
SELECT * FROM tb_funcionarios f LEFT JOIN tb_veiculos v ON v.id_funcionario = f.id
UNION
SELECT * FROM tb_funcionarios f RIGHT JOIN tb_veiculos v ON v.id_funcionario = f.id;
/*===================================================================================*/

/*EQUI JOIN*/
SELECT * FROM  tb_funcionarios f INNER JOIN tb_cpfs cpfs ON f.id = cpfs.id;
SELECT * FROM  tb_funcionarios f INNER JOIN tb_cpfs cpfs USING(id);

/*SELF JOIN */
SELECT a.nome AS CLIENTE, b.nome AS "QUEM_INDICOU"
 FROM tb_clientes a JOIN tb_clientes b ON a.quem_indicou  = b.id;
 /*=============================================================*/
 
 /*Tri-relacionamento com INNER JOIN */
 SELECT * FROM tb_funcionarios f
 INNER JOIN tb_veiculos v ON v.id_funcionario = f.id
 INNER JOIN tb_cpfs cpfs ON cpfs.id = f.id; 
 
 /* CRIANDO VISÕES*/
 CREATE VIEW funcionarios_a AS SELECT * FROM tb_funcionarios WHERE salario >= 2000;
 /* Alterando a visão */
 DROP VIEW funcionarios_a ;
 
 SELECT * FROM funcionarios_a;
 
 /*Mostrando a regra da view*/
 UPDATE tb_funcionarios SET salario = 1500 WHERE id = 3;
 
 
CREATE TABLE tb_clientes (
	id int unsigned not null auto_increment,
    nome varchar(45)  not null,
    quem_indicou  int unsigned, 
    PRIMARY KEY (id),
    CONSTRAINT fk_tb_clientes_quem_indicou FOREIGN KEY (quem_indicou) REFERENCES tb_clientes (id)
);

INSERT INTO tb_clientes (id, nome, quem_indicou) VALUES (1, 'Andre', NULL);
INSERT INTO tb_clientes (id, nome, quem_indicou) VALUES (2, 'Samuel', 1);
INSERT INTO tb_clientes (id, nome, quem_indicou) VALUES (3, 'Carlos', 2);
INSERT INTO tb_clientes (id, nome, quem_indicou) VALUES (4, 'Rafael', 1); 

SELECT * FROM tb_clientes;

CREATE TABLE tb_cpfs(
 id int unsigned  not null,
 cpf varchar(14) not null,
 PRIMARY KEY (id),
 CONSTRAINT fk_tb_cpfs_tb_funcionarios FOREIGN KEY (id) REFERENCES tb_funcionarios (id)
);

INSERT INTO tb_cpfs (id, cpf) VALUES (1, "111.111.111-11");
INSERT INTO tb_cpfs (id, cpf) VALUES (2, "222.222.222-22");
INSERT INTO tb_cpfs (id, cpf) VALUES (3, "333.333.333-33");
INSERT INTO tb_cpfs (id, cpf) VALUES (5, "555.555.555-55");

SELECT * FROM tb_cpfs;



INSERT INTO tb_veiculos (id_funcionario, veiculo, placa) VALUES (null, "Moto", "SB-0003")