DELIMITER //
--Creación del proc y declaración de parametros
CREATE PROCEDURE proc_insert_cuenta(
    IN saldo DECIMAL(10, 2),
    IN tipo VARCHAR(50),
    IN id_cliente INT,
    OUT resul BOOLEAN
)

BEGIN
--esta variable es para verificar si hay clientes en la tabla clientes
    DECLARE v_cliente_existente INT;

    --se verifica
    SELECT COUNT(*) INTO v_cliente_existente
    FROM tbl_datoscliente
    WHERE id_cliente = id_cliente;

    --si hay clientes, entonces procede con la inserción
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
