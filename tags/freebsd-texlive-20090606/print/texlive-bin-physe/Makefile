# New ports collection makefile for:	texlive-bin-physe
# Date created:		26/01/2009 16:04:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-physe
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The PHYSE format.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
