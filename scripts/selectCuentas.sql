DELIMITER //
CREATE PROCEDURE selectCuentas(IN idCliente INT)
BEGIN
    SELECT *
    FROM tbl_cuenta
    WHERE id_cliente = idCliente;
END//

DELIMITER ;