DELIMITER //
CREATE PROCEDURE proc_update_cliente(
    IN p_nombre VARCHAR(50),
    IN p_apellido VARCHAR(50),
    IN p_id_cuenta INT,
    OUT resul BOOLEAN
)
BEGIN
    UPDATE tbl_datoscliente AS tcl
    INNER JOIN tbl_cuenta AS tcu ON tcl.id_cliente = tcu.id_cuenta
    SET tcl.nombre = p_nombre, tcl.apellido = p_apellido
    WHERE tcu.id_cuenta = p_id_cuenta;
    SET resul = TRUE;
END //
DELIMITER ;
