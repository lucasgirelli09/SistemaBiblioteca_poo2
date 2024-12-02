DROP DATABASE IF EXISTS GerenciamentoLivros;
DROP SCHEMA IF EXISTS GerenciamentoLivros;
CREATE DATABASE GerenciamentoLivros;
USE GerenciamentoLivros;

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `GerenciamentoLivros` ;
USE `GerenciamentoLivros` ;

-- -----------------------------------------------------
-- Table `GerenciamentoLivros`.`TabelaLivros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GerenciamentoLivros`.`TabelaLivros` (
  `LivroId` INT NOT NULL AUTO_INCREMENT,
  `LivroTitulo` VARCHAR(100) NOT NULL,
  `LivroAnoPublicacao` INT NOT NULL,
  `LivroGenero` VARCHAR(80) NULL,
  PRIMARY KEY (`LivroId`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `GerenciamentoLivros`.`TabelaAutores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GerenciamentoLivros`.`TabelaAutores` (
  `AutorId` INT NOT NULL AUTO_INCREMENT,
  `AutorNome` VARCHAR(45) NOT NULL,
  `AutorSobrenome` VARCHAR(100) NOT NULL,
  `AutorNacionalidade` VARCHAR(45) NULL,
  PRIMARY KEY (`AutorId`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `GerenciamentoLivros`.`RelacaoLivrosAutores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `GerenciamentoLivros`.`RelacaoLivrosAutores` (
  `Livros_LivroId` INT NOT NULL,
  `Autores_AutorId` INT NOT NULL,
  PRIMARY KEY (`Livros_LivroId`, `Autores_AutorId`),
  INDEX `fk_RelacaoLivrosAutores_Autores1_idx` (`Autores_AutorId` ASC) VISIBLE,
  INDEX `fk_RelacaoLivrosAutores_Livros_idx` (`Livros_LivroId` ASC) VISIBLE,
  CONSTRAINT `fk_RelacaoLivrosAutores_Livros`
    FOREIGN KEY (`Livros_LivroId`)
    REFERENCES `GerenciamentoLivros`.`TabelaLivros` (`LivroId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_RelacaoLivrosAutores_Autores1`
    FOREIGN KEY (`Autores_AutorId`)
    REFERENCES `GerenciamentoLivros`.`TabelaAutores` (`AutorId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
