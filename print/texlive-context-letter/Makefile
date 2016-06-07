# $FreeBSD$

PORTNAME=	context-letter
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	ConTeXt package for writing letters

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/mkii/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
