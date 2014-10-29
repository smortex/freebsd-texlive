# $FreeBSD$

PORTNAME=	lh
PORTVERSION=	20140418
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Cyrillic fonts that support LaTeX standard encodings.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/source/jknappen/ec/ecbi.mf:${PORTSDIR}/print/texlive-ec

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
