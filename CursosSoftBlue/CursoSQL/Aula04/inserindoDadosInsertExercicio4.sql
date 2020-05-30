USE softblue_curso_exercicios;

/*EXERCÍCIO 1 */
/*Inserindo ID e Tipo de Curso na tabela tb_tipo_cursos */
INSERT INTO tb_tipo_cursos (codigo, tipo) VALUES (1, "Banco de dados");
INSERT INTO tb_tipo_cursos (codigo, tipo) VALUES (2, "Programação");
INSERT INTO tb_tipo_cursos (codigo, tipo) VALUES (3, "Modelagem de dados");

/*Inserindo id, nome e telefone na tb_instrutor*/
INSERT INTO tb_instrutor (id, instrutor, telefone) VALUES (1, "André Milani", "1111-1111");
INSERT INTO tb_instrutor (id, instrutor, telefone) VALUES (2, "Carlos Tosin", "2222-2222");

/*Inserindo id de cada curso seus respectivos nome, instrutores e precos */
INSERT INTO tb_cursos (id, nome, id_curso, id_instrutor, preco) VALUES (1, "Java Fundamentos", 2, 2, 270);
INSERT INTO tb_cursos (id, nome, id_curso, id_instrutor, preco) VALUES (2, "Java Avançado", 2, 2, 330);
INSERT INTO tb_cursos (id, nome, id_curso, id_instrutor, preco) VALUES (3, "SQL Completo", 1, 1, 170);
INSERT INTO tb_cursos (id, nome, id_curso, id_instrutor, preco) VALUES (4, "PHP Básico", 2, 1, 270);

/*Inserindo id aluno, nome, telefone, e-mail e data nascimento */

/*Inserindo nova coluna (endereco) na tabela aluno */
ALTER TABLE tb_aluno ADD COLUMN endereco varchar(64) not null;
ALTER TABLE tb_aluno DROP COLUMN telefone;
ALTER TABLE tb_aluno DROP COLUMN nascimento;
/*===========================================================*/

/*Inserindo dados na tabela aluno por id, nome, endereco e email */
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (1, "José", "Rua XV de Novembro 72", "jose@softblue.com.br");
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (2, "Wagner", "Av. Paulista", "wagner@softblue.com.br");
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (3, "Emílio", "Rua Lajes 103, ap: 71", "emilia@softblue.com.br");
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (4, "Cris", "Rua Tauney 22", "cris@softblue.com.br");
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (5, "Regina", "Rua Sales 305", "regina@softblue.com.br");
INSERT INTO tb_aluno (id, nome, endereco, email) VALUES (6, "Fernando", "Av. Central 30", "fernando@softblue.com.br");

/*Inserindo dadso na tabela pedidos */
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (1, 2, 15/04/2010, "11:23:32");
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (2, 2, '2010/04/15', '14:36:21');
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (3, 3, '2010/04/16', '11:17:45');
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (4, 4, '2010/04/17', '14:27:22');
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (5, 5, '2010/04/18', '11:18:19');
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (6, 6, '2010/04/19', '13:47:35');
INSERT INTO tb_pedido (numero_pedido, id_aluno, data_pedido, hora_pedido) VALUES (7, 6, '2010/04/20', '18:13:44');
UPDATE tb_pedido SET data_pedido = '2010/04/15' WHERE numero_pedido = 1;
SET SQL_SAFE_UPDATES = 0;

/*Inserindo dados na tb_detalhe_pedido */
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (1, 1, 270); 
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (1, 2, 330);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (2, 1, 270);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (2, 2, 330);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (2, 3, 170);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (3, 4, 270);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (4, 2, 330);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (4, 4, 270);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (5, 3, 170);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (6, 3, 170);
INSERT INTO tb_detalhe_pedido (id_numero_pedido, id_curso, valor_curso) VALUES (7, 4, 270);

/*EXERCÍCIO 2 */
/*Exibir todas as informações de todos os alunos; */
SELECT * FROM tb_aluno;
/*====================================================*/
/*Exibir somente o título de cada curso da Softblue; */
SELECT nome FROM tb_cursos; 

/*Exibir somente o título e valor de cada curso da Softblue cujo preço seja maior que 200;*/
SELECT nome, preco FROM tb_cursos WHERE preco > 200; 

/*Exibir somente o título e valor de cada curso da Softblue cujo preço seja maior que 200 e menor que 300*/
SELECT nome, preco FROM tb_cursos WHERE preco > 200 AND preco < 300;

/*Exibir as informações da tabela PEDIDOS para os pedidos realizados entre 15/04/2010 e 18/04/2010; */
SELECT * FROM tb_pedido WHERE data_pedido > '2010/04/15' AND data_pedido < '2010/04/19'; 

/*Exibir as informações da tabela PEDIDOS para os pedidos realizados na data de 15/04/2010*/
SELECT * FROM tb_pedido WHERE data_pedido = '2010/04/15';

/*Utilizando o banco de dados criado nos módulos anteriores, realize as seguintes instruções: */
UPDATE tb_aluno SET endereco = "Av. Brasil 778" WHERE id = 1;

/*Altere o e-mail do aluno CRIS para 'cristiano@softblue.com.br';*/
UPDATE tb_aluno SET email = "cristiano@softblue.com.br" WHERE id = 4;

/*Aumente em 10% o valor dos cursos abaixo de 300;*/
UPDATE tb_cursos SET preco = (preco * 10) / 100 WHERE preco < 300;
UPDATE tb_cursos SET preco = preco * 1.1 WHERE preco < 300;
/*=====================================================*/
/*Altere o nome do curso de Php Básico para Php Fundamentos;*/
UPDATE tb_cursos SET nome = 'Php Fundamentos' WHERE id = 4;

SELECT * FROM tb_aluno;
SELECT * FROM tb_cursos;

