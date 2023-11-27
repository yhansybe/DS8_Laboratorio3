DELIMITER //
CREATE PROCEDURE proc_insert_cliente(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_direccion VARCHAR(100),
    IN p_telefono_movil VARCHAR(15),
    OUT resul BOOLEAN
)
BEGIN
    INSERT INTO tbl_datoscliente (nombre, apellido, direccion, telefono_movil)
    VALUES (p_nombre, p_apellido, p_direccion, p_telefono_movil);
    BEGIN
        SET resul = TRUE;
    END;
END //
DELIMITER ;
