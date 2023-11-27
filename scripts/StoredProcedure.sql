DELIMITER //
CREATE PROCEDURE sp_insertar_cuenta(
    IN p_saldo DECIMAL(10, 2),
    IN p_tipo VARCHAR(50),
    IN p_id_cliente INT,
    OUT p_resultado BOOLEAN
)
BEGIN
    -- Verificar si el cliente existe
    DECLARE v_cliente_existente INT;
    SELECT COUNT(*) INTO v_cliente_existente
    FROM tbl_datoscliente
    WHERE id_cliente = p_id_cliente;

    -- Insertar la cuenta si el cliente existe
    IF v_cliente_existente > 0 THEN
        INSERT INTO tbl_cuenta (saldo, tipo, id_cliente)
        VALUES (p_saldo, p_tipo, p_id_cliente);
        
        SET p_resultado = TRUE;
    ELSE
        SET p_resultado = FALSE;
    END IF;
END //
DELIMITER ;