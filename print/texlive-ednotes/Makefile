# $FreeBSD$

PORTNAME=	ednotes
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset scholarly editions

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/ncctools/afterpackage.sty:${PORTSDIR}/print/texlive-ncctools

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
