# $FreeBSD$

PORTNAME=	platex
PORTVERSION=	20160621
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	pLaTeX2e and miscellaneous macros for pTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/ptex/morisawa.map:${PORTSDIR}/print/texlive-ptex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
