﻿DELIMITER //
CREATE PROCEDURE proc_insert_cuenta(
    IN p_saldo DECIMAL(10, 2),
    IN p_tipo VARCHAR(50),
    IN p_id_cliente INT,
    OUT resul BOOLEAN
)

BEGIN
    DECLARE v_cliente_existente INT;


    SELECT COUNT(*) INTO v_cliente_existente
    FROM tbl_datoscliente
    WHERE id_cliente = id_cliente;

    IF v_cliente_existente > 0 THEN
        INSERT INTO tbl_cuenta (saldo, tipo, id_cliente)
        VALUES (saldo, tipo, id_cliente);
        SELECT 'Cuenta agregada con exito' AS mensaje;
        SET resul = TRUE;
    ELSE
        SELECT 'Error: Cliente no encontrado' AS mensaje;
    END IF;

END //
DELIMITER ;
