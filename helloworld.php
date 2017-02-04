<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "test";

$conn = new mysqli($servername, $username, $password, $dbname);

if (!$conn) {
	die("Connection Failed " . mysqli_connect_error());
}

$sql = "SELECT nombre, counter from items";
$result = mysqli_query($conn ,$sql);

while ($row = mysqli_fetch_assoc($result)) {
	echo "Nombre:".$row['nombre'] . "|Counter:".$row['counter'] . ";";
}

?>