<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "test";

$score = $_POST["scorePost"];

$conn = new mysqli($servername, $username, $password, $dbname);

if (!$conn) {
	die("Connection Failed " . mysqli_connect_error());
}

$sql = "INSERT INTO score (score) values ('".$score."')";
$result = mysqli_query($conn ,$sql);

?>