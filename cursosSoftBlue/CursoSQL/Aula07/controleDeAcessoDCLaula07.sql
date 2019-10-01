/*CREATE USER 'robert'@'200.200.190.190' IDENTIFIED BY 'caetano123456' ; /*Acesso somente pelo IP especificado*/
/*CREATE USER 'robert'@'%' IDENTIFIED BY 'caetano123456' ; /*Acessa de qualquer local ou endereço*/

CREATE USER 'robert'@'localhost' IDENTIFIED BY 'caetano123456' ; /*Acesso apenas pela própria máquina*/
GRANT ALL ON softblue_curso_exercicios.* TO 'robert'@'localhost'; /* Garante acesso no seguinte DB em todas estruturas*/

CREATE USER 'robert'@'%' IDENTIFIED BY 'caetanoviagem' ; /*Acesso apenas pela própria máquina*/
GRANT SELECT ON softblue_curso_exercicios.* TO 'robert'@'%';
GRANT INSERT ON softblue_curso_exercicios.* TO 'robert'@'%';
GRANT INSERT ON softblue_curso_exercicios.tb_aluno TO 'robert'@'%';

/*Removendo acessos*/
REVOKE INSERT ON softblue_curso_exercicios.tb_aluno FROM 'robert'@'%';
REVOKE SELECT ON softblue_curso_exercicios.tb_aluno FROM 'robert'@'%'; /*Não remove permissões em estruturas individuais caso a 
																		 permissão a elas foram dadas através do (nome_bd.*) com asterisco*/
REVOKE SELECT ON softblue_curso_exercicios.* FROM 'robert'@'%';

REVOKE ALL ON softblue_curso_exercicios.* FROM 'robert'@'localhost';

/*Deletando usuario*/
DROP USER 'robert'@'%';
DROP USER 'robert'@'localhost';

/*Consultando usuario e suas permissões*/
SELECT USER FROM mysql.user;
/*Mostra privilegios do usuario*/
SHOW GRANTS FOR 'robert'@'localhost';

REVOKE SELECT ON softblue_curso_exercicios.* FROM 'robert'@'%';
REVOKE INSERT ON softblue_curso_exercicios.* FROM 'robert'@'%';

GRANT ALL ON tb_aluno TO 'robert'@'localhost';
REVOKE UPDATE ON tb_aluno FROM 'robert'@'localhost';


