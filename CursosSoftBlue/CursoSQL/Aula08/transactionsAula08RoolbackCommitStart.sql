USE softblue_cursosql_aulas;
SHOW ENGINES;

CREATE TABLE contas_bancarias(
	id int unsigned not null auto_increment,
    titular varchar(45) not null,
    saldo double not null,
    PRIMARY KEY (id)
) engine = InnoDB;



INSERT INTO contas_bancarias (titular, saldo) VALUES ('André', 1000);
INSERT INTO contas_bancarias (titular, saldo) VALUES ('Carlos', 1000);
SELECT * FROM contas_bancarias;

start transaction;
UPDATE contas_bancarias SET saldo = saldo - 100 WHERE id = 1;
UPDATE contas_bancarias SET saldo = saldo + 100 WHERE id = 2;
rollback;

start transaction;
UPDATE contas_bancarias SET saldo = saldo - 100 WHERE id = 1;
UPDATE contas_bancarias SET saldo = saldo + 100 WHERE id = 2;
commit;

/*Ideal sempre verificar o SHOW ENGINES, para analisar qual engine da suporte a transações*/
/*Quando for normalizar é preciso revisar verificando necessidade das tabelas a serem transacionais ou não;*/


