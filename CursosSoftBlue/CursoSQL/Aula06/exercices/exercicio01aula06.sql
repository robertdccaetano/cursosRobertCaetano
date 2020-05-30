USE softblue_curso_exercicios;

/*Utilizando o banco de dados criado nos módulos anteriores, realize as seguintes instruções:
 Selecione os nomes de todos os alunos que já fizeram alguma matrícula na Softblue, sem repetição; */
 SELECT DISTINCT(a.nome) FROM tb_aluno a INNER JOIN tb_pedido p ON p.id_aluno = a.id;
 
 /*Exiba o nome do aluno mais antigo da Softblue*/
 SELECT DISTINCT(a.nome) FROM tb_aluno a INNER JOIN tb_pedido p ON p.id_aluno = a.id ORDER BY data_pedido ASC LIMIT 1;  
 
 /*Exiba o nome do aluno mais recente da Softblue; */
 SELECT DISTINCT(a.nome) FROM tb_aluno a INNER JOIN tb_pedido p ON p.id_aluno = a.id ORDER BY data_pedido DESC LIMIT 1;
 
 /*Exiba o nome do terceiro aluno mais antigo da Softblue; */
 SELECT DISTINCT (a.nome) FROM tb_aluno a  INNER JOIN tb_pedido p ON p.id_aluno = a.id ORDER BY data_pedido ASC LIMIT 2, 1;
 
 /*Exiba a quantidade de cursos que já foram vendidos pela Softblue; */
 SELECT COUNT(c.nome) FROM tb_cursos c INNER JOIN tb_detalhe_pedido dp ON c.id = dp.id_curso;
 
 /*Exiba o valor total já arrecadado pelos cursos vendidos pela Softblue;*/
 SELECT SUM(valor_curso) FROM tb_detalhe_pedido;
 
 /*Exiba o valor médio cobrado por curso para o pedido cujo CODIGO é 2; */
 SELECT AVG(valor_curso) FROM tb_detalhe_pedido WHERE id_numero_pedido = 2;
 
 /*Exiba o valor do curso mais caro da Softblue; */
 SELECT MAX(valor_curso) FROM tb_detalhe_pedido;
 
 /*Exiba o valor do curso mais barato da Softblue;*/
 SELECT MIN(valor_curso) FROM tb_detalhe_pedido;
 
 /*Exiba o valor total de cada pedido realizado na Softblue; */
 SELECT id_numero_pedido, SUM(valor_curso) AS valor_total_pedido FROM tb_detalhe_pedido GROUP BY id_numero_pedido;
 
 /*Exiba os nomes dos instrutores da Softblue e a quantidade de cursos que cada um tem sob sua responsabilidade; */
SELECT i.instrutor, COUNT(*) FROM tb_cursos c INNER JOIN tb_instrutor i ON c.id_instrutor  = i.id GROUP BY i.instrutor;

/*Exiba o número do pedido, nome do aluno e valor para todos os pedidos realizados na Softblue cujo valor total sejam maiores que 500; */
SELECT p.numero_pedido, a.nome, SUM(dp.valor_curso) FROM tb_detalhe_pedido dp
INNER JOIN tb_pedido p ON p.numero_pedido = dp.id_numero_pedido
INNER JOIN tb_aluno a ON a.id = p.id_aluno
GROUP BY p.numero_pedido HAVING SUM(dp.valor_curso) > 500;
    
/*Exiba o número do pedido, nome do aluno e quantos cursos foram comprados no pedido para todos os pedidos realizados na Softblue que compraram dois ou mais cursos; */
SELECT p.numero_pedido, a.nome, COUNT(*) FROM tb_detalhe_pedido dp
INNER JOIN tb_pedido p ON dp.id_numero_pedido = p.numero_pedido
INNER JOIN tb_aluno a ON a.id = p.id_aluno
GROUP BY p.numero_pedido HAVING COUNT(*) > 1;

/*Exiba o nome e endereço de todos os alunos que morem em Avenidas (Av.); */
SELECT a.nome, a.endereco FROM tb_aluno a WHERE endereco LIKE 'Av%';

/*Exiba os nomes dos cursos de Java da Softblue; */
SELECT c.nome AS 'Nome dos Cursos' FROM tb_cursos c WHERE nome LIKE '%java%';


 SELECT * FROM tb_instrutor;
 SELECT * FROM tb_aluno;
 SELECT * FROM tb_cursos;
 SELECT * FROM tb_pedido;
 SELECT * FROM tb_pedido;
 SELECT * FROm tb_detalhe_pedido;
 
 