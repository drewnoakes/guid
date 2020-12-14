# guid

Command line tool for generating GUID strings.

## Install

```
dotnet tool install -g guid
```

## Usage

```
guid [option]
```

Where `[option]` is an optional single character that controls formatting:

- `N` &mdash; `4FDAB48CC00E498CB244D523D5B8156D`
- `D` &mdash; `4FDAB48C-C00E-498C-B244-D523D5B8156D`
- `B` &mdash; `{4FDAB48C-C00E-498C-B244-D523D5B8156D}`
- `P` &mdash; `(4FDAB48C-C00E-498C-B244-D523D5B8156D)`

When unspecified, `d` formatting is used. Use lowercase `[option]` for lowercase output.
