# Stopwatch-Application

A small stopwatch program written in C#

Deliverables:
- Contains two methods: Start() and Stop()
- The duration between when the stopwatch starts and stops is tracked using a TimeStamp data type
- The duration is then printed to the console

Expectations:

- User should be able to start and stop multiple times throughout the same execution of the program
- The duration of each instance is kept track of regardless of when each instance is started or stopped
- Cannot start the same stopwatch if it is already "started" state (avoiding overwriting of the initial start time)
- The error described in the latter should be handled gracefully

Test Cases:

- Tested via starting --> executing some mundane, but time consuming, tasks --> stopping (actual time kept on physical stopwatch and         compared to results)
- various starts and stops in different areas of the Main method
- Multiple starts on the same instance simultaneously
- Similar other quality assurance tests
