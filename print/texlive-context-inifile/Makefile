# $FreeBSD$

PORTNAME=	context-inifile
PORTVERSION=	20161023
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	An ini-file pretty-printer, using ConTeXt

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/mkii/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
