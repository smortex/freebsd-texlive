PROG=	TLPort.exe
SRCS=	TLPort.cs PackageCollection.cs IPackage.cs Package.cs

MCS?=	gmcs

${PROG}: ${SRCS}
	${MCS} ${SRCS} -out:${PROG}

clean:
	rm -f ${PROG}
