# GustavLindblom.Website

Repository containing the source code for www.gustavlindblom.se

## Building

1. Clone the repository
```bash
git clone https://github.com/glindblom/gustavlindblom.website.git
```

3. Navigate to repository
```bash
cd GustavLindblom\
```

2. Restore nuget packages
```bash
dotnet restore
```

3. Publish the solution
```bash
powershell -file publish-solution.ps1
```