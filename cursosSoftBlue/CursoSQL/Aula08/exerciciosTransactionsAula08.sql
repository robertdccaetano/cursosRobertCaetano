USE softblue_curso_exercicios;

CREATE TABLE conta_bancaria
(
	codigo integer unsigned not null auto_increment,
    titular varchar(32) not null,
    saldo double not null,
    PRIMARY KEY(codigo)
); engine = InnoDB;

INSERT INTO CONTA_BANCARIA VALUES (1, 'André', 213);
INSERT INTO CONTA_BANCARIA VALUES (2, 'Diogo', 489); 
INSERT INTO CONTA_BANCARIA VALUES (3, 'Rafael', 568);
INSERT INTO CONTA_BANCARIA VALUES (4, 'Carlos', 712);
INSERT INTO CONTA_BANCARIA VALUES (5, 'Peter', -38);

SELECT * FROM conta_bancaria;
SET sql_safe_updates = 0;

start transaction;
UPDATE conta_bancaria SET saldo = saldo + (saldo * 3) / 100 WHERE saldo > 0;
rollback;
commit;


