<?php

require_once __DIR__ . '\..\vendor\autoload.php';

DesignPatterns\Model\Connection::connect();

\View\UserView::index();
