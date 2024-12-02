-- Procedimento para povoar a tabela Livros_has_Autor com validações
DROP PROCEDURE IF EXISTS povoar_Livros_has_Autor;

DELIMITER $$

CREATE PROCEDURE povoar_Livros_has_Autor(IN QntdLinhas INT)
BEGIN
    DECLARE qtde INT DEFAULT 1;

    -- Loop para inserir os registros desejados
    WHILE qtde <= QntdLinhas DO
        -- Verifica se o registro já existe antes de inserir
        IF NOT EXISTS (
            SELECT 1 
            FROM Livros_has_Autor 
            WHERE Livros_idLivro = qtde AND Autor_idAutor = qtde
        ) THEN
            INSERT INTO Livros_has_Autor (Livros_idLivro, Autor_idAutor) 
            VALUES (qtde, qtde);
        END IF;
        
        SET qtde = qtde + 1;
    END WHILE;
END $$

DELIMITER ;

-- Chamando o procedimento para popular a tabela
CALL povoar_Livros_has_Autor(1000);
