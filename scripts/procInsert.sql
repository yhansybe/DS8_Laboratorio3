DELIMITER //

CREATE PROCEDURE proc_insert_cliente(
    IN nombre VARCHAR(50),
    IN apellido VARCHAR(50),
    IN direccion VARCHAR(100),
    IN telefono_movil VARCHAR(15),
    OUT resul BOOLEAN
)
BEGIN
    BEGIN
        SET resul = TRUE;
    END;
    INSERT INTO tbl_datoscliente (nombre, apellido, direccion, telefono_movil)
    VALUES (nombre, apellido, direccion, telefono_movil);
END //

DELIMITER ;
