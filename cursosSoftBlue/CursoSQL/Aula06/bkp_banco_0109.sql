CREATE DATABASE  IF NOT EXISTS `softblue_cursosql_aulas` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `softblue_cursosql_aulas`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: softblue_cursosql_aulas
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `funcionarios_a`
--

DROP TABLE IF EXISTS `funcionarios_a`;
/*!50001 DROP VIEW IF EXISTS `funcionarios_a`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `funcionarios_a` AS SELECT 
 1 AS `id`,
 1 AS `nome`,
 1 AS `salario`,
 1 AS `departamento`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_clientes` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `quem_indicou` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tb_clientes_quem_indicou` (`quem_indicou`),
  CONSTRAINT `fk_tb_clientes_quem_indicou` FOREIGN KEY (`quem_indicou`) REFERENCES `tb_clientes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clientes`
--

LOCK TABLES `tb_clientes` WRITE;
/*!40000 ALTER TABLE `tb_clientes` DISABLE KEYS */;
INSERT INTO `tb_clientes` VALUES (1,'Andre',NULL),(2,'Samuel',1),(3,'Carlos',2),(4,'Rafael',1);
/*!40000 ALTER TABLE `tb_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cpfs`
--

DROP TABLE IF EXISTS `tb_cpfs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_cpfs` (
  `id` int(10) unsigned NOT NULL,
  `cpf` varchar(14) NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_tb_cpfs_tb_funcionarios` FOREIGN KEY (`id`) REFERENCES `tb_funcionarios` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cpfs`
--

LOCK TABLES `tb_cpfs` WRITE;
/*!40000 ALTER TABLE `tb_cpfs` DISABLE KEYS */;
INSERT INTO `tb_cpfs` VALUES (1,'111.111.111-11'),(2,'222.222.222-22'),(3,'333.333.333-33'),(5,'555.555.555-55');
/*!40000 ALTER TABLE `tb_cpfs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionarios`
--

DROP TABLE IF EXISTS `tb_funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_funcionarios` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `salario` double NOT NULL DEFAULT '0',
  `departamento` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `indc_departamentos` (`departamento`),
  KEY `indc_nome` (`nome`(6))
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionarios`
--

LOCK TABLES `tb_funcionarios` WRITE;
/*!40000 ALTER TABLE `tb_funcionarios` DISABLE KEYS */;
INSERT INTO `tb_funcionarios` VALUES (1,'Fernando',1863.4,'TI'),(2,'Guilherme',3025,'TI'),(3,'Fabio',1500,'TI'),(5,'Isabela',2662,'Jurídico');
/*!40000 ALTER TABLE `tb_funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_salario`
--

DROP TABLE IF EXISTS `tb_salario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_salario` (
  `faixa` varchar(45) NOT NULL,
  `inicio` double NOT NULL,
  `fim` double NOT NULL,
  PRIMARY KEY (`faixa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_salario`
--

LOCK TABLES `tb_salario` WRITE;
/*!40000 ALTER TABLE `tb_salario` DISABLE KEYS */;
INSERT INTO `tb_salario` VALUES ('Analista JR',1000,2000),('Analista PLENO',2000,4000);
/*!40000 ALTER TABLE `tb_salario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_veiculos`
--

DROP TABLE IF EXISTS `tb_veiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_veiculos` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_funcionario` int(10) unsigned DEFAULT NULL,
  `veiculo` varchar(45) NOT NULL DEFAULT '',
  `placa` varchar(10) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  KEY `fk_veiculos_funcionarios` (`id_funcionario`),
  CONSTRAINT `fk_veiculos_funcionarios` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_veiculos`
--

LOCK TABLES `tb_veiculos` WRITE;
/*!40000 ALTER TABLE `tb_veiculos` DISABLE KEYS */;
INSERT INTO `tb_veiculos` VALUES (1,1,'Carro','SB-0001'),(2,5,'Carro','SB-0002'),(3,NULL,'Moto','SB-0003');
/*!40000 ALTER TABLE `tb_veiculos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'softblue_cursosql_aulas'
--

--
-- Dumping routines for database 'softblue_cursosql_aulas'
--

--
-- Final view structure for view `funcionarios_a`
--

/*!50001 DROP VIEW IF EXISTS `funcionarios_a`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `funcionarios_a` AS select `tb_funcionarios`.`id` AS `id`,`tb_funcionarios`.`nome` AS `nome`,`tb_funcionarios`.`salario` AS `salario`,`tb_funcionarios`.`departamento` AS `departamento` from `tb_funcionarios` where (`tb_funcionarios`.`salario` >= 2000) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-01 20:34:40
