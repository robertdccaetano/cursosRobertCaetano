USE softblue_cursosql_aulas;

INSERT INTO tb_funcionarios (id, nome, salario, departamento) VALUES (1, 'Fernando', 1400, 'TI');

SELECT * FROM tb_funcionarios;
SELECT * FROM tb_funcionarios WHERE salario > 2000;
SELECT * FROM tb_funcionarios WHERE nome = 'José';
SELECT * FROM tb_funcionarios WHERE id = 3;

UPDATE tb_funcionarios SET salario = 2500 WHERE nome = 'Guilherme';
UPDATE tb_funcionarios SET salario = salario * 1.1 ;

/*Arredondando casas decimais com ROUND no máximo 2 casas*/
UPDATE tb_funcionarios SET salario = ROUND(salario * 1.1, 2 );
/*Alterando função do SAFE UPDATE MYSQL (DESABILITA)  libera atualização de tabelas por inteiro*/
SET SQL_SAFE_UPDATES = 0;
/*Alterando função do SAFE UPDATE MYSQL (HABILITA)  libera atualização de tabelas por inteiro*/
SET SQL_SAFE_UPDATES = 1;
/*===========================================================================================*/

UPDATE tb_funcionarios SET salario = salario * 1.1 WHERE id = 1;

INSERT INTO tb_funcionarios (id, nome, salario, departamento) VALUES (2, 'Guilherme', 1400, 'TI');
INSERT INTO tb_funcionarios (nome, salario, departamento) VALUES ('Fabio', 1700, 'TI');
INSERT INTO tb_funcionarios (nome, salario, departamento) VALUES ('Jose', 1800, 'Marketing');
INSERT INTO tb_funcionarios (nome, salario, departamento) VALUES ('Isabela', 2200, 'Jurídico');

/*Deletando funcionario com base no seu ID*/
DELETE FROM tb_funcionarios WHERE id = 4;

INSERT INTO tb_veiculos (id_funcionario, veiculo, placa) VALUES (1, 'Carro', 'SB-0001');
INSERT INTO tb_veiculos (id_funcionario, veiculo, placa) VALUES (1, 'Carro', 'SB-0002');
SELECT * FROM tb_veiculos;

UPDATE tb_veiculos SET id_funcionario = 5 WHERE id = 2;

INSERT INTO tb_salario (faixa, inicio, fim) VALUES ('Analista JR', 1000, 2000);
INSERT INTO tb_salario (faixa, inicio, fim) VALUES ('Analista PLENO', 2000, 4000);
SELECT * FROM tb_salario;

/*Utilizando apelidos em tabelas mais sentindo em relacionamento de tabelas na consulta*/
SELECT * FROM tb_funcionarios f  WHERE f.salario > 2000;

/*Utilizando apelido de campo*/
SELECT nome AS 'Funcionário', salario FROM tb_funcionarios f  WHERE f.salario > 2000;

SELECT * FROM tb_funcionarios WHERE nome = 'Guilherme';

SELECT * FROM tb_funcionarios WHERE id = 5;

/* Usando UNION(elimina registros duplicasdos) do SELECT*/
SELECT * FROM tb_funcionarios WHERE nome = 'Guilherme'
UNION
SELECT * FROM tb_funcionarios WHERE id = 5;
/*=====================================================*/

/*Usando UNION[ALL] (traz registros duplicados)*/
SELECT * FROM tb_funcionarios WHERE nome = 'Guilherme'
UNION ALL
SELECT * FROM tb_funcionarios WHERE nome = 'Guilherme';


