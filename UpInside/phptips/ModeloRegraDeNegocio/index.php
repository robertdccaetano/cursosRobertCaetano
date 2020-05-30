<?php

require __DIR__ . "/vendor/autoload.php";
use Source\Models\User;

$user = new User();

$user = (new Source\Models\User())->findById(13); 

$user->first_name = "Robert";
$user->last_name = "Caetano";
$user->email = "robertvisualmidia@gmail.com";
$user->passwd = "123456";

if ( !$user->save() ) {
    echo "<h3>Ooops: {$user->fail()->getMessage()}</h3>";
}

echo "<h2>Ususário: </h2> <pre>";
print_r($user->fetch()->data());
echo "</pre>";