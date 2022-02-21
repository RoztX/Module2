using Module2;
using Autofac;

var config = new Config();
var container = config.RegistrarDependency();
var starter = container.Resolve<Starter>();
starter.Run();