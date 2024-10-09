using KeypadPhoneConverter.Infrastructure.Interfaces;

public class App
{
    private readonly IInputService _inputService;
    private readonly IKeypadService _keypadService;
    private readonly IOutputService _outputService;

    public App(IInputService inputService,
               IKeypadService keypadService,
               IOutputService outputService)
    {
        _inputService = inputService;
        _keypadService = keypadService;
        _outputService = outputService;
    }

    public void Run()
    {
        _outputService.DisplayKeypadOutput("33#", _keypadService.ConvertToText("33#"));
        _outputService.DisplayKeypadOutput("227*#", _keypadService.ConvertToText("227*#"));
        _outputService.DisplayKeypadOutput("4433555 555666#", _keypadService.ConvertToText("4433555 555666#"));
        _outputService.DisplayKeypadOutput("8 88777444666*664#", _keypadService.ConvertToText("8 88777444666*664#"));

        while (true)
        {
            var input = _inputService.GetKeypadInput();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            var output = _keypadService.ConvertToText(input);

            _outputService.DisplayKeypadOutput(input, output);
        }
    }
}