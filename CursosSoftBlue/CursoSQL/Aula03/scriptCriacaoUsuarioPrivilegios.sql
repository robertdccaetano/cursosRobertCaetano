CREATE USER 'root'@'%' IDENTIFIED BY 'root';
GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' WITH GRANT OPTION;

CREATE USER 'loucademia'@'%' IDENTIFIED BY 'loucademia';
GRANT ALL PRIVILEGES ON loucademia.* TO 'loucademia'@'%';
GRANT SELECT, INSERT ON loucademia.* TO 'loucademia'@'%';

CREATE USER 'loucademia'@'localhost' IDENTIFIED BY 'loucademia';
GRANT ALL PRIVILEGES ON loucademia.* TO 'loucademia'@'localhost';

SHOW GRANTS FOR 'loucademia'@'localhost';


GRANT SELECT ON loucademia.* TO 'loucademia'@'localhost';
/* Esse bloco de comandos soluciona o erro 1142 SELECT for table user_variables_by_thread quando um especifico usuário precisa acessar apenas um SCHEMA*/
GRANT SELECT ON performance_schema.*
       TO 'loucademia'@'localhost';
