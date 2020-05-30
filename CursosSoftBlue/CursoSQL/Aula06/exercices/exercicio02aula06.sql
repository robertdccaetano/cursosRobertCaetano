USE softblue_curso_exercicios;

/*Utilizando subquery, exiba uma lista com os nomes dos cursos disponibilizados pela Softblue informando para cada curso qual o seu menor valor de venda já praticado; */
SELECT c.nome, (SELECT MIN(valor_curso) FROM tb_detalhe_pedido dp WHERE dp.id_curso = c.id) AS menor_valor FROM tb_cursos c;

/*Utilizando subquery e o parâmetro IN, exiba os nomes dos cursos disponibilizados pela Softblue cujo tipo de curso seja 'Programação'; */
SELECT c.nome FROM tb_cursos c WHERE c.id_curso IN (SELECT t.codigo FROM tb_tipo_cursos t WHERE t.tipo = 'Programação');


/*Utilizando subquery e o parâmetro EXISTS, exiba novamente os nomes dos cursos disponibilizados pela Softblue cujo tipo de curso seja 'Programação'; */
SELECT c.nome FROM tb_cursos c WHERE EXISTS (SELECT codigo FROM tb_tipo_cursos t WHERE t.codigo = c.id_curso  AND t.tipo = 'Programação');

/*Exiba uma lista com os nomes dos instrutores da Softblue e ao lado o total acumulado das vendas referente aos cursos pelo qual o instrutor é responsável; */
SELECT i.instrutor,
(
	SELECT SUM(dp.valor_curso) FROM tb_detalhe_pedido dp 
	INNER JOIN tb_cursos c ON dp.id_curso = c.id WHERE c.id_instrutor = i.id
) 
AS TOTAL_VENDAS FROM tb_instrutor i;

/*Crie uma visão que exiba os nomes dos alunos e quanto cada um já comprou em cursos; */
CREATE VIEW ALUNOS_E_COMPRAS AS SELECT a.nome,
 (
	SELECT SUM(dp.valor_curso) FROM tb_detalhe_pedido dp
	INNER JOIN tb_pedido p ON p.numero_pedido = dp.id_numero_pedido
	WHERE p.id_aluno = a.id
)
 AS TOTAL_DECOMPRAS FROM tb_aluno a;
 
 SELECT * FROM ALUNOS_E_COMPRAS;


SELECT * FROM tb_instrutor;
SELECT * FROM tb_cursos;
SELECT * FROM tb_aluno;
SELECT * FROM tb_detalhe_pedido;
SELECT * FROM tb_pedido;
SELECT * FROM tb_tipo_cursos;