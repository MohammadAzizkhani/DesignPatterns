using StatePattern;
using StatePattern.Sample;
using StatePattern.Sample2;

//Canvas canvas = new(new SelectionTool());

//canvas.MouseDown();
//canvas.MouseUp();

//Context context = new(new ConcreteStateA());
//context.Request();

DirectionService directionService = new(new WalkingService());

directionService.GetDirection();
directionService.GetEta();
