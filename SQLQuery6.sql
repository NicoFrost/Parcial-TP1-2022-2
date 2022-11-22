SELECT C.idMateria,M.nombre,C.idCorrelativaMat,s.nombre FROM Correlativa AS C 
	INNER JOIN Materia AS M ON C.idMateria = M.id
	INNER JOIN Materia AS s ON C.idCorrelativaMat = s.id

--CONEXION ENTRE USUARIOS Y ALUMNOS Y MATERIAS
	SELECT u.id,u.nombre,u.password,p.nombre perfil,u.activo,a.materia,a.estado from UsuarioAlumno AS a 
	INNER JOIN Usuario AS U ON a.id = u.id 
	INNER JOIN Permiso AS p ON p.id = u.id
	WHERE a.materia = 1 

--CONTADOR MATERIAS DE ALUMNOS
SELECT COUNT(*) FROM UsuarioAlumno WHERE id = 1
SELECT * FROM UsuarioAlumno WHERE id = 2

--EXAMENES
SELECT u.id,u.nombre,u.password,p.nombre perfil,u.activo,a.materia,a.estado FROM UsuarioAlumno AS a 
	INNER JOIN Examen AS e ON 

INSERT INTO ExamenAlumno VALUES (1,3,2.50)

--OBTENCION ALUMNOS y UPDATE'S
SELECT u.id,u.nombre,u.password,p.nombre perfil,u.activo,a.materia,a.estado from UsuarioAlumno AS a INNER JOIN Usuario AS U ON a.id = u.id INNER JOIN Permiso AS p ON p.id = u.id_permiso WHERE a.materia = 1 AND a.id = 1
SELECT * FROM UsuarioAlumno WHERE id = 2 AND materia = 1
UPDATE UsuarioAlumno SET estado = 0 WHERE id = 1 AND materia = 1

--correlativas
SELECT c.*,m.nombre,m.idUserP_Asignado FROM Correlativa AS c INNER JOIN Materia AS m ON c.idCorrelativaMat = m.id WHERE c.idMateria = 3 AND c.idCorrelativaMat = 0

SELECT c.idMateria id,c.idCorrelativaMat,m.nombre,m.idUserP_Asignado FROM Correlativa AS c INNER JOIN Materia AS m ON c.idCorrelativaMat = m.id WHERE c.idMateria = 3

--ASISTENCIA
SELECT * FROM asistencia WHERE idAlumno = 2 GROUP BY idAlumno,idMateria,fechaAsistencia
INSERT INTO asistencia VALUES (2,3,'2022/11/23')


