CREATE DATABASE  IF NOT EXISTS `softblue_curso_exercicios` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `softblue_curso_exercicios`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: softblue_curso_exercicios
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
-- Temporary view structure for view `cursos_e_instrutores`
--

DROP TABLE IF EXISTS `cursos_e_instrutores`;
/*!50001 DROP VIEW IF EXISTS `cursos_e_instrutores`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `cursos_e_instrutores` AS SELECT 
 1 AS `nome`,
 1 AS `tipo`,
 1 AS `instrutor`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `pedidos_realizados`
--

DROP TABLE IF EXISTS `pedidos_realizados`;
/*!50001 DROP VIEW IF EXISTS `pedidos_realizados`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `pedidos_realizados` AS SELECT 
 1 AS `nome`,
 1 AS `data_pedido`,
 1 AS `numero_pedido`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `precos_programacao`
--

DROP TABLE IF EXISTS `precos_programacao`;
/*!50001 DROP VIEW IF EXISTS `precos_programacao`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `precos_programacao` AS SELECT 
 1 AS `nome`,
 1 AS `preco`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tb_aluno`
--

DROP TABLE IF EXISTS `tb_aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_aluno` (
  `id` int(10) unsigned NOT NULL DEFAULT '0',
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `endereco` varchar(64) NOT NULL,
  KEY `ind_aluno` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_aluno`
--

LOCK TABLES `tb_aluno` WRITE;
/*!40000 ALTER TABLE `tb_aluno` DISABLE KEYS */;
INSERT INTO `tb_aluno` VALUES (1,'José','jose@softblue.com.br','Av. Brasil 778'),(2,'Wagner','wagner@softblue.com.br','Av. Paulista'),(3,'Emílio','emilia@softblue.com.br','Rua Lajes 103, ap: 71'),(4,'Cris','cristiano@softblue.com.br','Rua Tauney 22'),(5,'Regina','regina@softblue.com.br','Rua Sales 305'),(6,'Fernando','fernando@softblue.com.br','Av. Central 30');
/*!40000 ALTER TABLE `tb_aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cursos`
--

DROP TABLE IF EXISTS `tb_cursos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_cursos` (
  `id` int(10) unsigned NOT NULL DEFAULT '0',
  `nome` varchar(45) NOT NULL,
  `id_curso` int(10) unsigned NOT NULL,
  `id_instrutor` int(10) unsigned NOT NULL,
  `preco` float unsigned NOT NULL,
  KEY `ind_instrutor_curso` (`id_instrutor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cursos`
--

LOCK TABLES `tb_cursos` WRITE;
/*!40000 ALTER TABLE `tb_cursos` DISABLE KEYS */;
INSERT INTO `tb_cursos` VALUES (1,'Java Fundamentos',2,2,326.7),(2,'Java Avançado',2,2,330),(3,'SQL Completo',1,1,20.57),(4,'Php Fundamentos',2,1,326.7);
/*!40000 ALTER TABLE `tb_cursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_detalhe_pedido`
--

DROP TABLE IF EXISTS `tb_detalhe_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_detalhe_pedido` (
  `id_numero_pedido` int(10) unsigned NOT NULL,
  `id_curso` int(10) unsigned NOT NULL,
  `valor_curso` float unsigned NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_detalhe_pedido`
--

LOCK TABLES `tb_detalhe_pedido` WRITE;
/*!40000 ALTER TABLE `tb_detalhe_pedido` DISABLE KEYS */;
INSERT INTO `tb_detalhe_pedido` VALUES (1,1,270),(1,2,330),(2,1,270),(2,2,330),(2,3,170),(3,4,270),(4,2,330),(4,4,270),(5,3,170),(6,3,170),(7,4,270),(7,4,270);
/*!40000 ALTER TABLE `tb_detalhe_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_instrutor`
--

DROP TABLE IF EXISTS `tb_instrutor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_instrutor` (
  `id` int(10) unsigned NOT NULL DEFAULT '0',
  `instrutor` varchar(45) NOT NULL,
  `telefone` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_instrutor`
--

LOCK TABLES `tb_instrutor` WRITE;
/*!40000 ALTER TABLE `tb_instrutor` DISABLE KEYS */;
INSERT INTO `tb_instrutor` VALUES (1,'André Milani','1111-1111'),(2,'Carlos Tosin','2222-2222');
/*!40000 ALTER TABLE `tb_instrutor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_pedido` (
  `numero_pedido` int(10) unsigned NOT NULL DEFAULT '0',
  `id_aluno` int(10) unsigned NOT NULL,
  `data_pedido` date NOT NULL,
  `hora_pedido` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pedido`
--

LOCK TABLES `tb_pedido` WRITE;
/*!40000 ALTER TABLE `tb_pedido` DISABLE KEYS */;
INSERT INTO `tb_pedido` VALUES (1,2,'2010-04-15','11:23:32'),(2,2,'2010-04-15','14:36:21'),(3,3,'2010-04-16','11:17:45'),(4,4,'2010-04-17','14:27:22'),(5,5,'2010-04-18','11:18:19'),(6,6,'2010-04-19','13:47:35'),(7,6,'2010-04-20','18:13:44');
/*!40000 ALTER TABLE `tb_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_tipo_cursos`
--

DROP TABLE IF EXISTS `tb_tipo_cursos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tb_tipo_cursos` (
  `codigo` int(10) unsigned NOT NULL DEFAULT '0',
  `tipo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_tipo_cursos`
--

LOCK TABLES `tb_tipo_cursos` WRITE;
/*!40000 ALTER TABLE `tb_tipo_cursos` DISABLE KEYS */;
INSERT INTO `tb_tipo_cursos` VALUES (1,'Banco de dados'),(2,'Programação'),(3,'Modelagem de dados');
/*!40000 ALTER TABLE `tb_tipo_cursos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'softblue_curso_exercicios'
--

--
-- Dumping routines for database 'softblue_curso_exercicios'
--

--
-- Final view structure for view `cursos_e_instrutores`
--

/*!50001 DROP VIEW IF EXISTS `cursos_e_instrutores`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `cursos_e_instrutores` AS select `c`.`nome` AS `nome`,`t`.`tipo` AS `tipo`,`i`.`instrutor` AS `instrutor` from ((`tb_cursos` `c` join `tb_tipo_cursos` `t` on((`c`.`id_curso` = `t`.`codigo`))) join `tb_instrutor` `i` on((`c`.`id_instrutor` = `i`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `pedidos_realizados`
--

/*!50001 DROP VIEW IF EXISTS `pedidos_realizados`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `pedidos_realizados` AS select `a`.`nome` AS `nome`,`p`.`data_pedido` AS `data_pedido`,`p`.`numero_pedido` AS `numero_pedido` from (`tb_pedido` `p` join `tb_aluno` `a` on((`p`.`id_aluno` = `a`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `precos_programacao`
--

/*!50001 DROP VIEW IF EXISTS `precos_programacao`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `precos_programacao` AS select `tb_cursos`.`nome` AS `nome`,`tb_cursos`.`preco` AS `preco` from `tb_cursos` where (`tb_cursos`.`id_curso` = 2) */;
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

-- Dump completed on 2019-09-01 20:36:50
