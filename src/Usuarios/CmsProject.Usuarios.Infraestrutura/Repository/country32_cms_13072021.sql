-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: country32_cms_database
-- ------------------------------------------------------
-- Server version	5.5.5-10.3.16-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20200916200531_01_migration_usuarios','3.1.8'),('20200916210124_02_migration_sistemas','3.1.8'),('20200917141649_03_migration_sistemas','3.1.8'),('20200921174550_04_migration_usuarios','3.1.8'),('20210205173854_01_initial_auth','3.1.8'),('20210205180742_02_migration_auth','3.1.8'),('20210205201209_03_migration_auth','3.1.8'),('20210209145419_04_migration_auth','3.1.8'),('20210422223918_migration01_templates','3.1.8'),('20210427141123_migration_02','3.1.8'),('20210427143453_migration_03','3.1.8'),('20210427162112_migration_04','3.1.8'),('20210427162628_migration_05','3.1.8'),('20210427191502_migration_06','3.1.8'),('20210427192607_migration_07','3.1.8'),('20210427204231_migration_08','3.1.8'),('20210427210029_migration_09','3.1.8');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroleclaims`
--

DROP TABLE IF EXISTS `aspnetroleclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ClaimValue` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ClaimValue` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderKey` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `PhoneNumber` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `Ativo` tinyint(1) DEFAULT NULL,
  `CPF_CNPJ` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `DataCancelamento` datetime(6) DEFAULT NULL,
  `DataCriacao` datetime(6) DEFAULT NULL,
  `DataRetorno` datetime(6) DEFAULT NULL,
  `IdAspnetUsers` char(36) DEFAULT NULL,
  `IdSistema` char(36) DEFAULT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `SobreNome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Status` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `TipoUsuario` int(11) DEFAULT NULL,
  `Discriminator` longtext CHARACTER SET utf8mb4 NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('06e23a95-678b-4593-a3ef-589e33583022','teste2@teste.com','TESTE2@TESTE.COM','teste2@teste.com','TESTE2@TESTE.COM',1,'AQAAAAEAACcQAAAAEKlojNWB4tpj4POGXbZGVa2w3AhQsBO0aga8UxnXWvrd58GOZBoRWymlTJhxbfODkg==','BK6JMIU3T3P4PHF6PWKLGWRFHVZHWS32','de8ef24d-6f23-46e3-a7e8-9e4333404b0c',NULL,0,0,NULL,1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'IdentityUser'),('0962efbe-267a-48ad-91c7-cc0f136caef1','TesteNome02@TesteNome02.com','TESTENOME02@TESTENOME02.COM','TesteNome02@TesteNome02.com','TESTENOME02@TESTENOME02.COM',1,'AQAAAAEAACcQAAAAEOxY2ZlSodaKnZQSDLVdZGs0gOVv1Pl0ZCkxjIwtRL774HfryKiaJt54Duu6eMr7GA==','LJRTSY6LVS6J33FLAPHKLLZ562MXBTLX','8b7a8278-af95-4907-8368-b42e88976c50',NULL,0,0,NULL,1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'IdentityUser'),('16625289-04f2-43b2-b888-79c00e088d0e','teste@teste.com','TESTE@TESTE.COM','teste@teste.com','TESTE@TESTE.COM',1,'AQAAAAEAACcQAAAAEP4YyvHK86kdFCqw6xAaPKsSfDJ4Jg/zWnDkcdgfq0eBFV3JXni4I3P7T84cNzsIlA==','PVRQ2P6PW7S6RVVVVAMZXW5O6UDSPU3Z','173dc4e1-f3ed-4836-8b0c-08619daae3e8',NULL,0,0,NULL,1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,''),('3fa85f64-5717-4562-b3fc-2c963f66afa6','username1','USERNAME1','username1@username1.com','USERNAME1@USERNAME1.COM',0,'AQAAAAEAACcQAAAAENJVa2wzzZ2vKdOIlDl6TDMhAIF/j/hecki4riWGgLxD5PlQvvlGW3PlukvuMxDxeA==','FXBP4TVCMWDQPUR5LLWVBZY6C3Y6Q6MR','14fdeaab-b6a0-45cf-a25c-43533fc4f40d',NULL,0,0,NULL,1,0,1,'username1','2021-02-19 17:58:36.357000','2021-02-19 17:58:36.357000','2021-02-19 17:58:36.357000',NULL,'3fa85f64-5717-4562-b3fc-2c963f66afa6','username1','username1','username1',0,'Usuarios'),('9d322462-b004-494d-aad6-0ed1852f3d5c','testeEmail_01@teste.com','TESTEEMAIL_01@TESTE.COM','testeEmail_01@teste.com','TESTEEMAIL_01@TESTE.COM',1,'AQAAAAEAACcQAAAAEEyb0/ComUd5sM6+2Nn88tm7rzxKkM6l13YEk6xsfXr/m3lzw5SdSQXeR5jqyS0P/Q==','YXFGISMY32S5JTIOCRQLVJRX7SXWDEKB','7826877d-0551-4bb4-90cc-e1e8ecd7c004',NULL,0,0,NULL,1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'IdentityUser'),('bf2f1e6b-a02a-41d5-8c28-f59e6e148251','teste3@teste.com','TESTE3@TESTE.COM','teste3@teste.com','TESTE3@TESTE.COM',1,'AQAAAAEAACcQAAAAEL9ZnYpqeOUQVnIr5T0tr+hU1G2e6TmqBsfY/SlHUi3Mgs5o4AJp/1IbEVSkMvCYOA==','PG7BLVBOORFGWHW5YH635OEKHL6AAWSB','89412471-5af6-426c-924f-843252649ec5',NULL,0,0,NULL,1,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'IdentityUser');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusertokens`
--

DROP TABLE IF EXISTS `aspnetusertokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `LoginProvider` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `backupelementofrontend`
--

DROP TABLE IF EXISTS `backupelementofrontend`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `backupelementofrontend` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `ElementoFrontEndId` char(36) DEFAULT NULL,
  `IdElementoFrontEnd` char(36) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_BackupElementoFrontEnd_ElementoFrontEndId` (`ElementoFrontEndId`),
  CONSTRAINT `FK_BackupElementoFrontEnd_ElementoFrontEnd_ElementoFrontEndId` FOREIGN KEY (`ElementoFrontEndId`) REFERENCES `elementofrontend` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `backupelementofrontend`
--

LOCK TABLES `backupelementofrontend` WRITE;
/*!40000 ALTER TABLE `backupelementofrontend` DISABLE KEYS */;
/*!40000 ALTER TABLE `backupelementofrontend` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `backuppagina`
--

DROP TABLE IF EXISTS `backuppagina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `backuppagina` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `IdPagina` char(36) NOT NULL,
  `PaginaId` char(36) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_BackupPagina_PaginaId` (`PaginaId`),
  CONSTRAINT `FK_BackupPagina_Paginas_PaginaId` FOREIGN KEY (`PaginaId`) REFERENCES `paginas` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `backuppagina`
--

LOCK TABLES `backuppagina` WRITE;
/*!40000 ALTER TABLE `backuppagina` DISABLE KEYS */;
/*!40000 ALTER TABLE `backuppagina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `elementofrontend`
--

DROP TABLE IF EXISTS `elementofrontend`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `elementofrontend` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `IdPagina` char(36) NOT NULL,
  `CaminhoArquivo` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Status` tinyint(1) NOT NULL,
  `EhArquivoFisico` tinyint(1) NOT NULL,
  `Workflow` int(11) NOT NULL,
  `PaginaId` char(36) DEFAULT NULL,
  `Tipo` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Conteudo` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ElementoFrontEnd_PaginaId` (`PaginaId`),
  CONSTRAINT `FK_ElementoFrontEnd_Paginas_PaginaId` FOREIGN KEY (`PaginaId`) REFERENCES `paginas` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `elementofrontend`
--

LOCK TABLES `elementofrontend` WRITE;
/*!40000 ALTER TABLE `elementofrontend` DISABLE KEYS */;
/*!40000 ALTER TABLE `elementofrontend` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imagens`
--

DROP TABLE IF EXISTS `imagens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `imagens` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `CaminhoImagem` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Status` tinyint(1) NOT NULL,
  `PaginaId` char(36) DEFAULT NULL,
  `Conteudo` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `EhArquivoFisico` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`),
  KEY `IX_Imagens_PaginaId` (`PaginaId`),
  CONSTRAINT `FK_Imagens_Paginas_PaginaId` FOREIGN KEY (`PaginaId`) REFERENCES `paginas` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imagens`
--

LOCK TABLES `imagens` WRITE;
/*!40000 ALTER TABLE `imagens` DISABLE KEYS */;
/*!40000 ALTER TABLE `imagens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paginas`
--

DROP TABLE IF EXISTS `paginas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paginas` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `Header` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Menu` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Body` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Footer` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Categoria` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Status` tinyint(1) NOT NULL,
  `WorkFlow` int(11) NOT NULL,
  `IdUsuario` char(36) NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000',
  `TemplatesId` char(36) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Paginas_TemplatesId` (`TemplatesId`),
  CONSTRAINT `FK_Paginas_Templates_TemplatesId` FOREIGN KEY (`TemplatesId`) REFERENCES `templates` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paginas`
--

LOCK TABLES `paginas` WRITE;
/*!40000 ALTER TABLE `paginas` DISABLE KEYS */;
/*!40000 ALTER TABLE `paginas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `templates`
--

DROP TABLE IF EXISTS `templates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `templates` (
  `Id` char(36) NOT NULL,
  `DataCriacao` datetime(6) NOT NULL,
  `DataAtualizacao` datetime(6) NOT NULL,
  `Nome` longtext CHARACTER SET utf8mb4 DEFAULT NULL,
  `Status` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `templates`
--

LOCK TABLES `templates` WRITE;
/*!40000 ALTER TABLE `templates` DISABLE KEYS */;
INSERT INTO `templates` VALUES ('8b524d91-33d8-45b5-8cae-a75ed06613b1','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','teste03',1),('98dfe01b-3c06-4d6e-8bab-d268a4e5fee4','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','teste02',1);
/*!40000 ALTER TABLE `templates` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-13  9:46:07
