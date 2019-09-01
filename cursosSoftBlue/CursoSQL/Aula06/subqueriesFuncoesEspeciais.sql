USE softblue_cursosql_aulas;
SELECT * FROM tb_funcionarios;
SELECT COUNT(*) FROM tb_funcionarios;
SELECT COUNT(*) FROM tb_funcionarios WHERE salario > 1600;
SELECT COUNT(*) FROM tb_funcionarios WHERE salario > 1600 AND departamento = 'Jurídico';

SELECT * FROM tb_funcionarios WHERE salario > 1600 AND departamento = 'Jurídico';

SELECT SUM(salario) FROM tb_funcionarios;
SELECT SUM(salario) FROM tb_funcionarios WHERE departamento = 'TI';

SELECT AVG(salario) FROM tb_funcionarios;
SELECT AVG(salario) FROM tb_funcionarios WHERE departamento = 'TI';

SELECT MAX(salario) FROM tb_funcionarios;
SELECT MAX(salario) FROM tb_funcionarios WHERE departamento = 'TI';

SELECT MIN(salario) FROM tb_funcionarios;
SELECT MIN(salario) FROM tb_funcionarios WHERE departamento = 'TI';

SELECT departamento FROM tb_funcionarios;
SELECT DISTINCT(departamento) FROM tb_funcionarios;

SELECT * FROM tb_funcionarios;
SELECT * FROM tb_funcionarios ORDER BY nome;
SELECT * FROM tb_funcionarios ORDER BY nome DESC;

SELECT * FROM tb_funcionarios ORDER BY salario;
SELECT * FROM tb_funcionarios ORDER BY departamento;
SELECT * FROM tb_funcionarios ORDER BY departamento DESC, salario DESC;

SELECT * FROM tb_funcionarios;
SELECT * FROM tb_funcionarios LIMIT 2;

SELECT * FROM tb_funcionarios LIMIT 2 OFFSET 1;
SELECT * FROM tb_funcionarios LIMIT 1, 2;

/* Parei 12:31 da aula */


