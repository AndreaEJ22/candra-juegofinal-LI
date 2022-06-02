<?php
$servername = "localhost";
$username = "root";
$password = "bolillo";
$dbname = "Laberinto";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$sql = "INSERT INTO DatosJugador (idDatosJugador, time, points)
VALUES (0, 10.5, 20)";

if ($conn->query($sql) === TRUE) {
  echo "New record created successfully";
} else {
  echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>