<?php
$conn = new mysqli("localhost", "root", "", "thebest");

if ($conn -> connect_error) {
    die("Csatlakozási hiba: ".$conn -> connect_error);
}