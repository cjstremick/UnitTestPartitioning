# UnitTestPartitioning

Some ideas to help partition unit tests for clarity

- Create a folder for the subject under test (using `Test` suffix).
- Create partial classes for each method under test.  The class name should 
  match the folder name.  The file name should indicate the method name.
- The tests should still follow the Triple-A (Arrange-Act-Assert) pattern.
- Each test make assert exactly one assertion.
- In general, tests should follow Method_Assertion_State convention for their names.  When there is no state for the test, this rule can be broken.
- When asserting exceptions, use Assert.Throws.  Never try-catch in unit tests.
