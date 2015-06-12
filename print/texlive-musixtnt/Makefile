# $FreeBSD$

PORTNAME=	musixtnt
PORTVERSION=	20150427
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A MusiXTeX extension library that enables transformations of the effect of notes commands

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/musixtex/musixtex.tex:${PORTSDIR}/print/texlive-musixtex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
