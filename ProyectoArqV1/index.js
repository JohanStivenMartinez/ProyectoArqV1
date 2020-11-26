const express = require('express');
const app = express();
const morgan = require('morgan');
const path = require('path');

//Settings
app.set('port', process.env.PORT || 1137);
app.engine('html', require('ejs').renderFile);
app.set('view engine', 'ejs');

//Middleware
app.use(morgan('dev'));
app.use(express.urlencoded({ extended: false }));
app.use(express.json());

//Routes
app.use('/api', require('../ProyectoArqV1/Views/Js/index'));
app.use('/api/agregarUsuario', require('../ProyectoArqV1/Views/Js/agregarUsuario'));
app.use('/api/iniciosesion', require('../ProyectoArqV1/Views/Js/iniciosesion'));
app.use('/api/sumbit', require('../ProyectoArqV1/Views/Js/iniciosesion'));
app.use('/api/indexUsuario', require('../ProyectoArqV1/Views/Js/indexUsuario'));
app.use('/api/crearServicio', require('../ProyectoArqV1/Views/Js/crearServicio'));
app.use('/api/buscarServicio', require('../ProyectoArqV1/Views/Js/buscarServicio'));
app.use('/api/cancelarServicio', require('../ProyectoArqV1/Views/Js/cancelarServicio'));

app.listen(app.get('port'), () => {
    console.log('Server on port', app.get('port'));
});