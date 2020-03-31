-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: querydb
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrador`
--

DROP TABLE IF EXISTS `administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrador` (
  `Id` int(11) NOT NULL,
  `NoControl` varchar(8) NOT NULL,
  `ApellidoPaterno` varchar(45) NOT NULL,
  `ApellidoMaterno` varchar(45) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Contraseña` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
/*!40000 ALTER TABLE `administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alumno` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `NoControl` varchar(8) NOT NULL,
  `ApellidoPaterno` varchar(45) NOT NULL,
  `ApellidoMaterno` varchar(45) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Contraseña` varchar(8) NOT NULL,
  `carrera_Id` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_alumno_carrera1_idx` (`carrera_Id`),
  CONSTRAINT `fk_alumno_carrera1` FOREIGN KEY (`carrera_Id`) REFERENCES `carrera` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrera`
--

DROP TABLE IF EXISTS `carrera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carrera` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrera`
--

LOCK TABLES `carrera` WRITE;
/*!40000 ALTER TABLE `carrera` DISABLE KEYS */;
INSERT INTO `carrera` VALUES (1,'Sistemas Computacionales',NULL),(2,'Industrial',NULL),(3,'Mecatronica',NULL),(4,'Administracion',NULL),(5,'Petrolera',NULL),(6,'Electromecanica',NULL),(9,'Diseño Industrial',NULL),(15,'adsjshdaslhjdlhjasd','adsjshdaslhjdlhjasdkjhasdklhasdkjasdhadsjshdaslhjdlhjasdkjhasdklhasdkjasdhadsjshdaslhjdlhjasdkjha');
/*!40000 ALTER TABLE `carrera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Cafeteria',NULL),(3,'Estacionamiento',NULL),(4,'Instalaciones',NULL),(5,'Laboratorios',NULL),(21,'HGJHGJHG','LSGJ DFSLGNJ FGLHFJAGKLJHG KLDF GHRKEGKRGHF,GHLSGJ DFSLGNJ FGLHFJAGKLJHG KLDF GHRKEGKRGHF,GH');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encuesta`
--

DROP TABLE IF EXISTS `encuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encuesta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Titulo` varchar(45) NOT NULL,
  `Descripcion` longtext,
  `Estado` tinyint(1) NOT NULL,
  `IdCategoria` int(11) NOT NULL,
  `IdAdministrador` int(11) NOT NULL,
  `Visualizar` tinyint(1) NOT NULL,
  `FechaCreacion` date NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkEncuestaCategoria` (`IdCategoria`),
  KEY `fkEncuestaAdministrador_idx` (`IdAdministrador`),
  CONSTRAINT `fkEncuestaAdministrador` FOREIGN KEY (`IdAdministrador`) REFERENCES `administrador` (`Id`),
  CONSTRAINT `fkEncuestaCategoria` FOREIGN KEY (`IdCategoria`) REFERENCES `categoria` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encuesta`
--

LOCK TABLES `encuesta` WRITE;
/*!40000 ALTER TABLE `encuesta` DISABLE KEYS */;
/*!40000 ALTER TABLE `encuesta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encuestado`
--

DROP TABLE IF EXISTS `encuestado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encuestado` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdEncuesta` int(11) NOT NULL,
  `alumno_Id` int(11) NOT NULL,
  `FechaRespuesta` date NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkEncuestadoEncuesta_idx` (`IdEncuesta`),
  KEY `fk_encuestado_alumno1_idx` (`alumno_Id`),
  CONSTRAINT `fkEncuestadoEncuesta` FOREIGN KEY (`IdEncuesta`) REFERENCES `encuesta` (`Id`),
  CONSTRAINT `fk_encuestado_alumno1` FOREIGN KEY (`alumno_Id`) REFERENCES `alumno` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encuestado`
--

LOCK TABLES `encuestado` WRITE;
/*!40000 ALTER TABLE `encuestado` DISABLE KEYS */;
/*!40000 ALTER TABLE `encuestado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opcionrespuesta`
--

DROP TABLE IF EXISTS `opcionrespuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opcionrespuesta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Respuesta` text NOT NULL,
  `IdPregunta` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkOpcionRespuestaPregunta` (`IdPregunta`),
  CONSTRAINT `fkOpcionRespuestaPregunta` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opcionrespuesta`
--

LOCK TABLES `opcionrespuesta` WRITE;
/*!40000 ALTER TABLE `opcionrespuesta` DISABLE KEYS */;
/*!40000 ALTER TABLE `opcionrespuesta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pregunta`
--

DROP TABLE IF EXISTS `pregunta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pregunta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Contenido` text NOT NULL,
  `IdTipoRespuesta` int(11) NOT NULL,
  `IdEncuesta` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkPreguntaTipoRespuesta` (`IdTipoRespuesta`),
  KEY `fkPreguntaEncuesta` (`IdEncuesta`),
  CONSTRAINT `fkPreguntaEncuesta` FOREIGN KEY (`IdEncuesta`) REFERENCES `encuesta` (`Id`),
  CONSTRAINT `fkPreguntaTipoRespuesta` FOREIGN KEY (`IdTipoRespuesta`) REFERENCES `tiporespuesta` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pregunta`
--

LOCK TABLES `pregunta` WRITE;
/*!40000 ALTER TABLE `pregunta` DISABLE KEYS */;
/*!40000 ALTER TABLE `pregunta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respuestaabierta`
--

DROP TABLE IF EXISTS `respuestaabierta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `respuestaabierta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Respuesta` text NOT NULL,
  `IdEncuestado` int(11) NOT NULL,
  `IdPregunta` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkRespuestaAEncuestado` (`IdEncuestado`),
  KEY `fkRespuestaAPregunta` (`IdPregunta`),
  CONSTRAINT `fkRespuestaAEncuestado` FOREIGN KEY (`IdEncuestado`) REFERENCES `encuestado` (`Id`),
  CONSTRAINT `fkRespuestaAPregunta` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respuestaabierta`
--

LOCK TABLES `respuestaabierta` WRITE;
/*!40000 ALTER TABLE `respuestaabierta` DISABLE KEYS */;
/*!40000 ALTER TABLE `respuestaabierta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respuestacerrada`
--

DROP TABLE IF EXISTS `respuestacerrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `respuestacerrada` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `IdOpcionRespuesta` int(11) NOT NULL,
  `IdEncuestado` int(11) NOT NULL,
  `IdPregunta` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fkRespuestaCOpcionRespuesta` (`IdOpcionRespuesta`),
  KEY `fkRespuestaCEncuestado` (`IdEncuestado`),
  KEY `fkRespuestaCPregunta` (`IdPregunta`),
  CONSTRAINT `fkRespuestaCEncuestado` FOREIGN KEY (`IdEncuestado`) REFERENCES `encuestado` (`Id`),
  CONSTRAINT `fkRespuestaCOpcionRespuesta` FOREIGN KEY (`IdOpcionRespuesta`) REFERENCES `opcionrespuesta` (`Id`),
  CONSTRAINT `fkRespuestaCPregunta` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respuestacerrada`
--

LOCK TABLES `respuestacerrada` WRITE;
/*!40000 ALTER TABLE `respuestacerrada` DISABLE KEYS */;
/*!40000 ALTER TABLE `respuestacerrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiporespuesta`
--

DROP TABLE IF EXISTS `tiporespuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiporespuesta` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(45) NOT NULL,
  `Descripcion` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiporespuesta`
--

LOCK TABLES `tiporespuesta` WRITE;
/*!40000 ALTER TABLE `tiporespuesta` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiporespuesta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-17 11:01:21
