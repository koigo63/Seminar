<?php
$file = fopen('chat.txt', 'a+');


if (isset($_GET['message'])) {
    $message = $_GET['message'];

    fputs($file, $message . "\n");
    echo "ok";
    die();

}

//$messages = file_get_contents('chat.txt');

$messages = [];

while (!feof($file)) {
    $messages[] = fgets($file);
}

$messages = array_reverse($messages);
$i = 0;
foreach ($messages as $message) {
    $i++;
    echo $message;
    if ($i > 10) break;
}