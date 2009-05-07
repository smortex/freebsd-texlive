# New ports collection makefile for:	texlive-bin-mltex
# Date created:		26/01/2009 16:04:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-mltex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The MLTeX system.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.latex.cnf:${PORTSDIR}/print/texlive-bin-latex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
