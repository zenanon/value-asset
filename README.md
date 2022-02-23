# value-asset
Minimal ScriptableObjects-as-variables base class and implementation for Unity.

# What is this?

A basic wrapper of ScriptableObjects around value types, to provide some common functionality and use cases.  Default values can be set in the editor, and then you can freely change the runtime value without that change getting persisted.  An event is provided to be notified when a value changes, to support event-driven functionality.

A sample scene shows how this can be used for UI.
