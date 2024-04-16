# example of using FParserTable

from FParserTable import FParserTable

parseTable = FParserTable()
with open('samples/jilba.fs') as f:
    text = f.read()
    parseTable.SetText(text)
    print(parseTable.GetOperands())
    print(parseTable.GetOperators())
    print(f"CL: {parseTable.GetCL()}")
    print(f"cl: {parseTable.GetCl()}")