# $FreeBSD$

PORTNAME=	cbfonts
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Complete set of Greek fonts

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/cbfonts-fd/lgrcmr.fd:${PORTSDIR}/print/texlive-cbfonts-fd

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
