/*Selecionando BD de exercícios */
USE softblue_curso_exercicios;

/*Desabilitando SAFE UPDATE do MySql para atualizar registros e tabelas */
SET SQL_SAFE_UPDATES = 0;

/*Utilizando o banco de dados criado nos módulos anteriores, realize as seguintes uniões de tabelas: */
/*Exiba uma lista com os títulos dos cursos da Softblue e o tipo de curso ao lado;*/
SELECT nome, tipo FROM tb_cursos cursos INNER JOIN tb_tipo_cursos tipos ON cursos.id_curso = tipos.codigo;

/*Exiba uma lista com os títulos dos cursos da Softblue, tipo do curso, nome do instrutor responsável pelo mesmo e telefone; */
 SELECT nome, tipo, instrutor, telefone FROM tb_cursos cursos 
 INNER JOIN tb_tipo_cursos tipo ON  cursos.id_curso = tipo.codigo 
 INNER JOIN tb_instrutor instrutor ON instrutor.id = cursos.id_instrutor;

/*Exiba uma lista com o código e data e hora dos pedidos e os códigos dos cursos de cada pedido; */
SELECT p.numero_pedido, p.data_pedido, p.hora_pedido, d.id_curso, c.nome FROM tb_pedido p
INNER JOIN tb_detalhe_pedido d ON p.numero_pedido = d.id_numero_pedido
INNER JOIN tb_cursos c ON c.id = d.id_curso;

/*Exiba uma lista com o código e data e hora dos pedidos e os títulos dos cursos de cada pedido; */
SELECT p.numero_pedido, p.data_pedido, p.hora_pedido, c.nome AS "Nome do Curso" FROM tb_pedido p
INNER JOIN tb_detalhe_pedido d ON p.numero_pedido = d.id_numero_pedido
INNER JOIN tb_cursos c ON c.id = d.id_curso;

/*Exiba uma lista com o código e data e hora dos pedidos, nome do aluno e os títulos dos cursos de cada pedido;*/
SELECT p.numero_pedido, p.data_pedido, p.hora_pedido, a.nome, c.nome FROM tb_pedido p
INNER JOIN tb_detalhe_pedido d ON p.numero_pedido = d.id_numero_pedido
INNER JOIN tb_aluno a ON p.id_aluno = a.id
INNER JOIN tb_cursos c ON d.id_curso = c.id;

/*FAZENDO VIEWS */
/*Crie uma visão que traga o título e preço somente dos cursos de programação da Softblue; */
CREATE VIEW precos_programacao AS SELECT nome, preco FROM tb_cursos WHERE id_curso = 2; 
SELECT * FROM precos_programacao;
/*==========================================================================================*/

/*Crie uma visão que traga os títulos dos cursos, tipo do curso e nome do instrutor;*/
CREATE VIEW cursos_e_instrutores AS SELECT c.nome, t.tipo, i.instrutor FROM tb_cursos c
INNER JOIN tb_tipo_cursos t ON c.id_curso = t.codigo
INNER JOIN tb_instrutor i ON c.id_instrutor = i.id;
SELECT * FROM cursos_e_instrutores;

/*Crie uma visão que exiba os pedidos realizados, informando o nome do aluno, data e código do pedido;*/
CREATE VIEW pedidos_realizados AS SELECT a.nome, p.data_pedido, p.numero_pedido FROM tb_pedido p
INNER JOIN tb_aluno a ON p.id_aluno = a.id;

DROP VIEW pedidos_realizados;
SELECT * FROM pedidos_realizados;
